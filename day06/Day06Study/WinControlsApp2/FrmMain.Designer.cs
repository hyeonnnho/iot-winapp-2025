namespace WinControlsApp2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            label1 = new Label();
            TxtName = new TextBox();
            label2 = new Label();
            TxtPersonalNumber = new MaskedTextBox();
            label3 = new Label();
            TxtPhoneNumber = new MaskedTextBox();
            label4 = new Label();
            RdoMale = new RadioButton();
            RdoFemale = new RadioButton();
            groupBox1 = new GroupBox();
            BtnCheck = new Button();
            groupBox2 = new GroupBox();
            BtnNext = new Button();
            Rdo4 = new RadioButton();
            Rdo3 = new RadioButton();
            Rdo2 = new RadioButton();
            Rdo1 = new RadioButton();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            BtnCheck2 = new Button();
            CboTestNumber = new TextBox();
            CboTestName = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            TxtResult = new TextBox();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(69, 14);
            label1.TabIndex = 0;
            label1.Text = "  이      름 :   ";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(94, 20);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 21);
            TxtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(76, 14);
            label2.TabIndex = 0;
            label2.Text = " 주 민 번 호 :  ";
            // 
            // TxtPersonalNumber
            // 
            TxtPersonalNumber.Location = new Point(94, 58);
            TxtPersonalNumber.Mask = "000000-0000000";
            TxtPersonalNumber.Name = "TxtPersonalNumber";
            TxtPersonalNumber.Size = new Size(100, 21);
            TxtPersonalNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(87, 14);
            label3.TabIndex = 0;
            label3.Text = "휴 대 폰  번 호 : ";
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new Point(94, 96);
            TxtPhoneNumber.Mask = "000-0000-0000";
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.Size = new Size(100, 21);
            TxtPhoneNumber.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(66, 14);
            label4.TabIndex = 3;
            label4.Text = "  성     별 :   ";
            // 
            // RdoMale
            // 
            RdoMale.AutoSize = true;
            RdoMale.Location = new Point(94, 130);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(47, 18);
            RdoMale.TabIndex = 4;
            RdoMale.TabStop = true;
            RdoMale.Text = "남성";
            RdoMale.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Location = new Point(147, 130);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(47, 18);
            RdoFemale.TabIndex = 5;
            RdoFemale.TabStop = true;
            RdoFemale.Text = "여성";
            RdoFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnCheck);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(RdoFemale);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(RdoMale);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtPhoneNumber);
            groupBox1.Controls.Add(TxtPersonalNumber);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 193);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "기초 인적 사항";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(119, 164);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(75, 23);
            BtnCheck.TabIndex = 6;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnNext);
            groupBox2.Controls.Add(Rdo4);
            groupBox2.Controls.Add(Rdo3);
            groupBox2.Controls.Add(Rdo2);
            groupBox2.Controls.Add(Rdo1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(218, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(554, 392);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "문제";
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(448, 349);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(100, 26);
            BtnNext.TabIndex = 10;
            BtnNext.Text = "다음 문제";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // Rdo4
            // 
            Rdo4.AutoSize = true;
            Rdo4.Font = new Font("나눔고딕", 11F, FontStyle.Bold);
            Rdo4.Location = new Point(348, 350);
            Rdo4.Name = "Rdo4";
            Rdo4.Size = new Size(35, 21);
            Rdo4.TabIndex = 9;
            Rdo4.TabStop = true;
            Rdo4.Text = "4";
            Rdo4.UseVisualStyleBackColor = true;
            // 
            // Rdo3
            // 
            Rdo3.AutoSize = true;
            Rdo3.Font = new Font("나눔고딕", 11F, FontStyle.Bold);
            Rdo3.Location = new Point(246, 350);
            Rdo3.Name = "Rdo3";
            Rdo3.Size = new Size(35, 21);
            Rdo3.TabIndex = 9;
            Rdo3.TabStop = true;
            Rdo3.Text = "3";
            Rdo3.UseVisualStyleBackColor = true;
            // 
            // Rdo2
            // 
            Rdo2.AutoSize = true;
            Rdo2.Font = new Font("나눔고딕", 11F, FontStyle.Bold);
            Rdo2.Location = new Point(144, 350);
            Rdo2.Name = "Rdo2";
            Rdo2.Size = new Size(35, 21);
            Rdo2.TabIndex = 9;
            Rdo2.TabStop = true;
            Rdo2.Text = "2";
            Rdo2.UseVisualStyleBackColor = true;
            // 
            // Rdo1
            // 
            Rdo1.AutoSize = true;
            Rdo1.Font = new Font("나눔고딕", 11F, FontStyle.Bold);
            Rdo1.Location = new Point(42, 350);
            Rdo1.Name = "Rdo1";
            Rdo1.Size = new Size(35, 21);
            Rdo1.TabIndex = 9;
            Rdo1.TabStop = true;
            Rdo1.Text = "1";
            Rdo1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(6, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(542, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnCheck2);
            groupBox3.Controls.Add(CboTestNumber);
            groupBox3.Controls.Add(CboTestName);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(12, 211);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 112);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "수험생 정보";
            // 
            // BtnCheck2
            // 
            BtnCheck2.Location = new Point(119, 83);
            BtnCheck2.Name = "BtnCheck2";
            BtnCheck2.Size = new Size(75, 23);
            BtnCheck2.TabIndex = 6;
            BtnCheck2.Text = "확인";
            BtnCheck2.UseVisualStyleBackColor = true;
            BtnCheck2.Click += BtnCheck2_Click;
            // 
            // CboTestNumber
            // 
            CboTestNumber.Location = new Point(73, 50);
            CboTestNumber.Name = "CboTestNumber";
            CboTestNumber.Size = new Size(121, 21);
            CboTestNumber.TabIndex = 2;
            // 
            // CboTestName
            // 
            CboTestName.FormattingEnabled = true;
            CboTestName.Items.AddRange(new object[] { "빅데이터분석기사", "정보처리기사", "Adsp", "Sqld" });
            CboTestName.Location = new Point(73, 22);
            CboTestName.Name = "CboTestName";
            CboTestName.Size = new Size(121, 22);
            CboTestName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 53);
            label6.Name = "label6";
            label6.Size = new Size(64, 14);
            label6.TabIndex = 0;
            label6.Text = "수험 번호 : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(64, 14);
            label5.TabIndex = 0;
            label5.Text = "시험 과목 : ";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(12, 329);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(200, 183);
            TxtResult.TabIndex = 3;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cs0001.png");
            imageList1.Images.SetKeyName(1, "cs0002.png");
            imageList1.Images.SetKeyName(2, "cs0003.png");
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 524);
            Controls.Add(TxtResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("나눔고딕", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtName;
        private Label label2;
        private MaskedTextBox TxtPersonalNumber;
        private Label label3;
        private MaskedTextBox TxtPhoneNumber;
        private Label label4;
        private RadioButton RdoMale;
        private RadioButton RdoFemale;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox CboTestNumber;
        private ComboBox CboTestName;
        private Label label6;
        private Label label5;
        private TextBox TxtResult;
        private Button BtnCheck;
        private Button BtnCheck2;
        private Button BtnNext;
        private RadioButton Rdo4;
        private RadioButton Rdo3;
        private RadioButton Rdo2;
        private RadioButton Rdo1;
        private PictureBox pictureBox1;
        private ImageList imageList1;
    }
}
