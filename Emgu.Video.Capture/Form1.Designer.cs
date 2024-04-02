namespace Emgu.Video.Capture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            StartCapture = new Button();
            StopCapture = new Button();
            pictureBox1 = new PictureBox();
            txtDeviceNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLearningRate = new TextBox();
            cmbRetMode = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbChainApproxMethod = new ComboBox();
            txtSubtractorHistory = new TextBox();
            txtSubtractorVarThreshold = new TextBox();
            toolTip1 = new ToolTip(components);
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtContoursSize = new TextBox();
            chkDetectShadows = new CheckBox();
            chkShowBackground = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // StartCapture
            // 
            StartCapture.Location = new Point(19, 12);
            StartCapture.Name = "StartCapture";
            StartCapture.Size = new Size(75, 23);
            StartCapture.TabIndex = 0;
            StartCapture.Text = "Start";
            StartCapture.UseVisualStyleBackColor = true;
            StartCapture.Click += StartCapture_Click;
            // 
            // StopCapture
            // 
            StopCapture.Location = new Point(111, 12);
            StopCapture.Name = "StopCapture";
            StopCapture.Size = new Size(75, 23);
            StopCapture.TabIndex = 1;
            StopCapture.Text = "Stop";
            StopCapture.UseVisualStyleBackColor = true;
            StopCapture.Click += StopCapture_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(200, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(689, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtDeviceNum
            // 
            txtDeviceNum.Location = new Point(111, 41);
            txtDeviceNum.Name = "txtDeviceNum";
            txtDeviceNum.Size = new Size(75, 23);
            txtDeviceNum.TabIndex = 3;
            txtDeviceNum.Text = "0";
            txtDeviceNum.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 44);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "Cam Index :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 150);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "Learning Rate";
            // 
            // txtLearningRate
            // 
            txtLearningRate.Location = new Point(19, 168);
            txtLearningRate.Name = "txtLearningRate";
            txtLearningRate.Size = new Size(75, 23);
            txtLearningRate.TabIndex = 6;
            txtLearningRate.Text = ".5";
            txtLearningRate.TextAlign = HorizontalAlignment.Center;
            txtLearningRate.TextChanged += txtLearningRate_TextChanged;
            // 
            // cmbRetMode
            // 
            cmbRetMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRetMode.FormattingEnabled = true;
            cmbRetMode.Items.AddRange(new object[] { "External", "List", "Ccomp", "Tree" });
            cmbRetMode.Location = new Point(100, 168);
            cmbRetMode.Name = "cmbRetMode";
            cmbRetMode.Size = new Size(86, 23);
            cmbRetMode.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 150);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 8;
            label3.Text = "Retrieval Mode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 205);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 9;
            label4.Text = "ChainApproxMethod";
            // 
            // cmbChainApproxMethod
            // 
            cmbChainApproxMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChainApproxMethod.FormattingEnabled = true;
            cmbChainApproxMethod.Items.AddRange(new object[] { "ChainApproxNone", "ChainApproxSimple", "ChainApproxTc89L1", "ChainApproxTc89Kcos", "LinkRuns" });
            cmbChainApproxMethod.Location = new Point(19, 223);
            cmbChainApproxMethod.Name = "cmbChainApproxMethod";
            cmbChainApproxMethod.Size = new Size(167, 23);
            cmbChainApproxMethod.TabIndex = 10;
            cmbChainApproxMethod.SelectedIndexChanged += cmbChainApproxMethod_SelectedIndexChanged;
            // 
            // txtSubtractorHistory
            // 
            txtSubtractorHistory.Location = new Point(19, 107);
            txtSubtractorHistory.Name = "txtSubtractorHistory";
            txtSubtractorHistory.Size = new Size(75, 23);
            txtSubtractorHistory.TabIndex = 11;
            txtSubtractorHistory.Text = "30";
            txtSubtractorHistory.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSubtractorVarThreshold
            // 
            txtSubtractorVarThreshold.Location = new Point(100, 107);
            txtSubtractorVarThreshold.Name = "txtSubtractorVarThreshold";
            txtSubtractorVarThreshold.Size = new Size(86, 23);
            txtSubtractorVarThreshold.TabIndex = 12;
            txtSubtractorVarThreshold.Text = "512";
            txtSubtractorVarThreshold.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 89);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 13;
            label5.Text = "History";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 89);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 14;
            label6.Text = "VarThreshold";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 259);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 15;
            label7.Text = "Contour Size";
            // 
            // txtContoursSize
            // 
            txtContoursSize.Location = new Point(19, 277);
            txtContoursSize.Name = "txtContoursSize";
            txtContoursSize.Size = new Size(75, 23);
            txtContoursSize.TabIndex = 16;
            txtContoursSize.Text = "512";
            txtContoursSize.TextAlign = HorizontalAlignment.Center;
            // 
            // chkDetectShadows
            // 
            chkDetectShadows.AutoSize = true;
            chkDetectShadows.Location = new Point(19, 316);
            chkDetectShadows.Name = "chkDetectShadows";
            chkDetectShadows.Size = new Size(110, 19);
            chkDetectShadows.TabIndex = 17;
            chkDetectShadows.Text = "Detect Shadows";
            chkDetectShadows.UseVisualStyleBackColor = true;
            // 
            // chkShowBackground
            // 
            chkShowBackground.AutoSize = true;
            chkShowBackground.Location = new Point(19, 493);
            chkShowBackground.Name = "chkShowBackground";
            chkShowBackground.Size = new Size(122, 19);
            chkShowBackground.TabIndex = 18;
            chkShowBackground.Text = "Show Background";
            chkShowBackground.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 524);
            Controls.Add(chkShowBackground);
            Controls.Add(chkDetectShadows);
            Controls.Add(txtContoursSize);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSubtractorVarThreshold);
            Controls.Add(txtSubtractorHistory);
            Controls.Add(cmbChainApproxMethod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbRetMode);
            Controls.Add(txtLearningRate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDeviceNum);
            Controls.Add(pictureBox1);
            Controls.Add(StopCapture);
            Controls.Add(StartCapture);
            Name = "Form1";
            Text = "Emgu : BackgroundSubtractorMOG2";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartCapture;
        private Button StopCapture;
        private PictureBox pictureBox1;
        private TextBox txtDeviceNum;
        private Label label1;
        private Label label2;
        private TextBox txtLearningRate;
        private ComboBox cmbRetMode;
        private Label label3;
        private Label label4;
        private ComboBox cmbChainApproxMethod;
        private TextBox txtSubtractorHistory;
        private TextBox txtSubtractorVarThreshold;
        private ToolTip toolTip1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtContoursSize;
        private CheckBox chkDetectShadows;
        private CheckBox chkShowBackground;
    }
}