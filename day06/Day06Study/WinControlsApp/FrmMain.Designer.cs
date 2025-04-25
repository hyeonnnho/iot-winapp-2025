namespace WinControlsApp
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
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuNewpage = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            MnuExit = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            TxtResult = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PicImage = new PictureBox();
            BtnCheck = new Button();
            groupBox3 = new GroupBox();
            LblUrl = new LinkLabel();
            CalSchedule = new MonthCalendar();
            DtpBirth = new DateTimePicker();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            groupBox4 = new GroupBox();
            PrgProcess = new ProgressBar();
            TrbProcess = new TrackBar();
            groupBox5 = new GroupBox();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox6 = new GroupBox();
            BtnRoot = new Button();
            BtnNode = new Button();
            LsvDummy = new ListView();
            imageList1 = new ImageList(components);
            TrvDummy = new TreeView();
            DlgOpenImage = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuNewpage, toolStripMenuItem1, MnuExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(&F)";
            // 
            // MnuNewpage
            // 
            MnuNewpage.Name = "MnuNewpage";
            MnuNewpage.Size = new Size(119, 22);
            MnuNewpage.Text = "새 글(&N)";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(116, 6);
            // 
            // MnuExit
            // 
            MnuExit.Name = "MnuExit";
            MnuExit.Size = new Size(119, 22);
            MnuExit.Text = "종료(&X)";
            MnuExit.Click += MnuExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.Name = "LblState";
            LblState.Size = new Size(66, 17);
            LblState.Text = "상태 : 일반";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(ChkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 93);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "일반 컨트롤";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(15, 56);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(350, 21);
            TxtResult.TabIndex = 3;
            TxtResult.Text = "Sample Text";
            // 
            // ChkItalic
            // 
            ChkItalic.Font = new Font("나눔고딕", 9F, FontStyle.Italic);
            ChkItalic.Location = new Point(281, 21);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(84, 19);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.Font = new Font("나눔고딕", 9F, FontStyle.Bold);
            ChkBold.Location = new Point(201, 21);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(84, 19);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "볼드";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(41, 19);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(154, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(29, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PicImage);
            groupBox2.Location = new Point(401, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 509);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "픽쳐 박스";
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.AppWorkspace;
            PicImage.Location = new Point(6, 19);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(372, 455);
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(266, 193);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(111, 40);
            BtnCheck.TabIndex = 3;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LblUrl);
            groupBox3.Controls.Add(BtnCheck);
            groupBox3.Controls.Add(CalSchedule);
            groupBox3.Controls.Add(DtpBirth);
            groupBox3.Controls.Add(TxtDay);
            groupBox3.Controls.Add(TxtMonth);
            groupBox3.Controls.Add(TxtYear);
            groupBox3.Location = new Point(791, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 509);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "기타 컨트롤";
            // 
            // LblUrl
            // 
            LblUrl.AutoSize = true;
            LblUrl.Location = new Point(12, 225);
            LblUrl.Name = "LblUrl";
            LblUrl.Size = new Size(63, 14);
            LblUrl.TabIndex = 3;
            LblUrl.TabStop = true;
            LblUrl.Text = "linkLabel1";
            LblUrl.LinkClicked += LblUrl_LinkClicked;
            // 
            // CalSchedule
            // 
            CalSchedule.Location = new Point(12, 19);
            CalSchedule.Name = "CalSchedule";
            CalSchedule.TabIndex = 2;
            CalSchedule.DateChanged += CalSchedule_DateChanged;
            // 
            // DtpBirth
            // 
            DtpBirth.Location = new Point(12, 193);
            DtpBirth.Name = "DtpBirth";
            DtpBirth.Size = new Size(200, 21);
            DtpBirth.TabIndex = 1;
            DtpBirth.ValueChanged += DtpBirth_ValueChanged;
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(277, 76);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(100, 21);
            TxtDay.TabIndex = 0;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(277, 49);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(100, 21);
            TxtMonth.TabIndex = 0;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(277, 22);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(100, 21);
            TxtYear.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(PrgProcess);
            groupBox4.Controls.Add(TrbProcess);
            groupBox4.Location = new Point(12, 126);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(384, 120);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "트랙바";
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(15, 80);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(350, 23);
            PrgProcess.TabIndex = 4;
            // 
            // TrbProcess
            // 
            TrbProcess.Location = new Point(15, 20);
            TrbProcess.Maximum = 100;
            TrbProcess.Name = "TrbProcess";
            TrbProcess.Size = new Size(350, 45);
            TrbProcess.TabIndex = 3;
            TrbProcess.TickFrequency = 10;
            TrbProcess.Scroll += TrbProcess_Scroll;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnMsgBox);
            groupBox5.Controls.Add(BtnModaless);
            groupBox5.Controls.Add(BtnModal);
            groupBox5.Location = new Point(12, 252);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(384, 100);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "모달, 모달리스";
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(227, 33);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(138, 40);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MessagesBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(121, 33);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(100, 40);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(15, 33);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(100, 40);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnRoot);
            groupBox6.Controls.Add(BtnNode);
            groupBox6.Controls.Add(LsvDummy);
            groupBox6.Controls.Add(TrvDummy);
            groupBox6.Location = new Point(12, 358);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(384, 178);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "트리뷰, 리스트뷰";
            // 
            // BtnRoot
            // 
            BtnRoot.Location = new Point(222, 149);
            BtnRoot.Name = "BtnRoot";
            BtnRoot.Size = new Size(75, 23);
            BtnRoot.TabIndex = 3;
            BtnRoot.Text = "루트 추가";
            BtnRoot.UseVisualStyleBackColor = true;
            BtnRoot.Click += BtnRoot_Click;
            // 
            // BtnNode
            // 
            BtnNode.Location = new Point(303, 149);
            BtnNode.Name = "BtnNode";
            BtnNode.Size = new Size(75, 23);
            BtnNode.TabIndex = 3;
            BtnNode.Text = "노드 추가";
            BtnNode.UseVisualStyleBackColor = true;
            BtnNode.Click += BtnNode_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.LargeImageList = imageList1;
            LsvDummy.Location = new Point(201, 21);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(177, 122);
            LsvDummy.SmallImageList = imageList1;
            LsvDummy.TabIndex = 2;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.SmallIcon;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder-normal.png");
            // 
            // TrvDummy
            // 
            TrvDummy.ImageIndex = 0;
            TrvDummy.ImageList = imageList1;
            TrvDummy.Location = new Point(6, 21);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.SelectedImageIndex = 0;
            TrvDummy.Size = new Size(189, 122);
            TrvDummy.TabIndex = 1;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("나눔고딕", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UI컨트롤 예제 윈앱";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox TxtResult;
        private CheckBox ChkBold;
        private ComboBox CboFonts;
        private CheckBox ChkItalic;
        private ToolStripStatusLabel LblState;
        private GroupBox groupBox4;
        private ProgressBar PrgProcess;
        private TrackBar TrbProcess;
        private GroupBox groupBox5;
        private Button BtnModal;
        private Button BtnModaless;
        private Button BtnMsgBox;
        private GroupBox groupBox6;
        private TreeView TrvDummy;
        private ListView LsvDummy;
        private Button BtnRoot;
        private Button BtnNode;
        private ImageList imageList1;
        private PictureBox PicImage;
        private Button BtnCheck;
        private OpenFileDialog DlgOpenImage;
        private LinkLabel LblUrl;
        private MonthCalendar CalSchedule;
        private DateTimePicker DtpBirth;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private TextBox TxtYear;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuNewpage;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem MnuExit;
    }
}
