using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.BgSegm;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using static Emgu.CV.VideoCapture;

namespace Emgu.Video.Capture
{
    public partial class Form1 : Form
    {

        private VideoCapture capture;
        private BackgroundSubtractorMOG2 backgroundSubtractor;
        private float MOG2LearningRate = .5f;
        private ChainApproxMethod ChnApprxMeth = ChainApproxMethod.ChainApproxNone;

        private Mat frame, foreground;
        private bool captureInProgress;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbRetMode.SelectedIndex = 0;
            cmbChainApproxMethod.SelectedIndex = 0;

            // ----------------------------------------------------------------
            backgroundSubtractor = new BackgroundSubtractorMOG2();

            backgroundSubtractor.DetectShadows = false;

            backgroundSubtractor.History = 30;
            toolTip1.SetToolTip(txtSubtractorHistory, "Increase the history length to make the algorithm more resistant to sudden changes");

            backgroundSubtractor.VarThreshold = 512;
            toolTip1.SetToolTip(txtSubtractorVarThreshold, "Decrease the variance threshold to make the algorithm more sensitive to small changes");
            // ----------------------------------------------------------------

            frame = new Mat();
            foreground = new Mat();
            captureInProgress = false;


        }

        private void StartCapture_Click(object sender, EventArgs e)
        {
            if (!captureInProgress)
            {
                try
                {
                    capture = new VideoCapture(Int32.Parse(txtDeviceNum.Text), API.DShow);
                    captureInProgress = true;
                    Application.Idle += ProcessFrame;
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Unable to open the camera. Please check if the camera is connected and working correctly.");
                }
            }
        }

        private void StopCapture_Click(object sender, EventArgs e)
        {
            if (captureInProgress)
            {
                captureInProgress = false;
                Application.Idle -= ProcessFrame;
                capture.Dispose();
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (capture != null && capture.Ptr != IntPtr.Zero)
            {
                capture.Read(frame);

                backgroundSubtractor.DetectShadows = chkDetectShadows.Checked;
                backgroundSubtractor.History = int.Parse(txtSubtractorHistory.Text);
                backgroundSubtractor.VarThreshold = int.Parse(txtSubtractorVarThreshold.Text);

                backgroundSubtractor.Apply(frame, foreground, MOG2LearningRate);

                Mat hierarchy = new();
                List<Rectangle> boundingBoxes = new List<Rectangle>();

                using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
                {
                    CvInvoke.FindContours(foreground, contours, hierarchy, (RetrType)cmbRetMode.SelectedIndex, (ChainApproxMethod)(cmbChainApproxMethod.SelectedIndex + 1)); // Does not like "ChainCode (0)"

                    for (int i = 0; i < contours.Size; i++)
                    {
                        if (contours[i].Length > int.Parse(txtContoursSize.Text))
                        {
                            boundingBoxes.Add(CvInvoke.BoundingRectangle(contours[i]));
                        }

                    }
                }

                Mat result = new Mat();
                frame.CopyTo(result);

                foreach (Rectangle box in boundingBoxes)
                {
                    CvInvoke.Rectangle(result, box, new MCvScalar(0, 0, 255), 1); // Draw red rectangles
                }

                pictureBox1.Image = result.ToBitmap();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureInProgress)
            {
                captureInProgress = false;
                Application.Idle -= ProcessFrame;
                capture.Dispose();
            }
        }

        private void txtLearningRate_TextChanged(object sender, EventArgs e)
        {
            float lrRes = .01f;
            if (float.TryParse(txtLearningRate.Text, out lrRes))
                MOG2LearningRate = lrRes;
        }

        private void cmbChainApproxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChnApprxMeth = (ChainApproxMethod)cmbChainApproxMethod.SelectedIndex;
        }

    }
}