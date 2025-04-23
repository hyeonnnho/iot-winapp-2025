namespace SyntaxWinApp01
{
    partial class FrmMain
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
            groupBox1 = new GroupBox();
            TxtResult = new TextBox();
            label5 = new Label();
            TxtPhone = new MaskedTextBox();
            NudAge = new NumericUpDown();
            TxtGender = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TxtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnMsg = new Button();
            PicResult = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(NudAge);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "정보입력/결과";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(6, 188);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(275, 93);
            TxtResult.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 170);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "결과";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(61, 117);
            TxtPhone.Mask = "000-0000-0000";
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(131, 23);
            TxtPhone.TabIndex = 4;
            // 
            // NudAge
            // 
            NudAge.Location = new Point(61, 59);
            NudAge.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            NudAge.Name = "NudAge";
            NudAge.Size = new Size(131, 23);
            NudAge.TabIndex = 2;
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(61, 88);
            TxtGender.MaxLength = 1;
            TxtGender.Name = "TxtGender";
            TxtGender.Size = new Size(131, 23);
            TxtGender.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "성별 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 120);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "번호 :";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(61, 29);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(131, 23);
            TxtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "이름 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "나이 : ";
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(472, 269);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 30);
            BtnMsg.TabIndex = 6;
            BtnMsg.Text = "체크";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // PicResult
            // 
            PicResult.BackColor = SystemColors.ControlLightLight;
            PicResult.Location = new Point(305, 12);
            PicResult.Name = "PicResult";
            PicResult.Size = new Size(250, 250);
            PicResult.SizeMode = PictureBoxSizeMode.StretchImage;
            PicResult.TabIndex = 2;
            PicResult.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(PicResult);
            Controls.Add(BtnMsg);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            Text = "문법학습 윈앱 01";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtName;
        private Button BtnMsg;
        private NumericUpDown NudAge;
        private Label label1;
        private Label label2;
        private TextBox TxtGender;
        private Label label3;
        private Label label4;
        private MaskedTextBox TxtPhone;
        private PictureBox PicResult;
        private Label label5;
        private TextBox TxtResult;
    }
}
