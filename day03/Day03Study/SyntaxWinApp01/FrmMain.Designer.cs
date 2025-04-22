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
            TxtPhone = new TextBox();
            LblPhone = new Label();
            TxtGender = new TextBox();
            LblGender = new Label();
            TxtAge = new TextBox();
            LblName = new Label();
            LblAge = new Label();
            TxtName = new TextBox();
            BtnCheck = new Button();
            LblResult = new Label();
            TxtResult = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtPhone);
            groupBox1.Controls.Add(LblPhone);
            groupBox1.Controls.Add(TxtGender);
            groupBox1.Controls.Add(LblGender);
            groupBox1.Controls.Add(TxtAge);
            groupBox1.Controls.Add(LblName);
            groupBox1.Controls.Add(LblAge);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "사람 정보 입력";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(70, 121);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(150, 23);
            TxtPhone.TabIndex = 4;
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.Location = new Point(10, 124);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(54, 15);
            LblPhone.TabIndex = 2;
            LblPhone.Text = "핸드폰 : ";
            LblPhone.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtGender
            // 
            TxtGender.Location = new Point(70, 92);
            TxtGender.Name = "TxtGender";
            TxtGender.Size = new Size(150, 23);
            TxtGender.TabIndex = 3;
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(22, 95);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(42, 15);
            LblGender.TabIndex = 2;
            LblGender.Text = "성별 : ";
            LblGender.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(70, 63);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(150, 23);
            TxtAge.TabIndex = 2;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(22, 37);
            LblName.Name = "LblName";
            LblName.Size = new Size(42, 15);
            LblName.TabIndex = 2;
            LblName.Text = "이름 : ";
            LblName.TextAlign = ContentAlignment.TopRight;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(22, 66);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(42, 15);
            LblAge.TabIndex = 2;
            LblAge.Text = "나이 : ";
            LblAge.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(70, 34);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 23);
            TxtName.TabIndex = 1;
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(472, 259);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 40);
            BtnCheck.TabIndex = 7;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(316, 28);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(42, 15);
            LblResult.TabIndex = 2;
            LblResult.Text = "결과 : ";
            // 
            // TxtResult
            // 
            TxtResult.BorderStyle = BorderStyle.FixedSingle;
            TxtResult.Location = new Point(316, 52);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.ReadOnly = true;
            TxtResult.Size = new Size(256, 201);
            TxtResult.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(TxtResult);
            Controls.Add(BtnCheck);
            Controls.Add(groupBox1);
            Controls.Add(LblResult);
            Name = "FrmMain";
            Text = "문법학습 윈앱 01";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnCheck;
        private Label LblResult;
        private TextBox TxtName;
        private TextBox TxtPhone;
        private Label LblPhone;
        private TextBox TxtGender;
        private Label LblGender;
        private TextBox TxtAge;
        private Label LblAge;
        private TextBox TxtResult;
        private Label LblName;
    }
}
