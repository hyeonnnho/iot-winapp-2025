using System.Windows.Forms.Design;

namespace WinControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // OS 전체 폰트 가져오기
            var Fonts = FontFamily.Families;
            // 폰트 콤보박스에 추가
            //CboFonts.Items.AddRange(Fonts);
            foreach (var font in Fonts)
            {
                CboFonts.Items.Add(font.Name);
            }

            LblState.Text = "상태 : 폰트 읽기 완료";

            toolTip1.SetToolTip(BtnModal, "모달창 연습 버튼"); // 툴팁 
            toolTip1.SetToolTip(TxtYear, "달력 선택 년도 표시 텍스트 박스"); // 툴팁
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0) return; // 선택된 폰트가 없으면 리턴

            FontStyle style = FontStyle.Regular; // 0 대신에 Regular을 사용

            if (ChkBold.Checked)
                style |= FontStyle.Bold; // FontStyle.Regular | Fontstyle.Bold => 0000 | 0001 => 0001

            if (ChkItalic.Checked)
                style |= FontStyle.Italic; // FontStyle.Regular | Fontstyle.Italic => 0001 | 0010 => 0011

            // CobFonts에서 선택된 글자로, 글자크기 12, 글자체 스타일 적용
            TxtResult.Font = new Font((string)CboFonts.SelectedItem, 12, style); // 폰트 크기 12로 설정
        }

        private void TrbProcess_Scroll(object sender, EventArgs e)
        {
            PrgProcess.Value = TrbProcess.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "모달창";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Red;
            frmModal.StartPosition = FormStartPosition.CenterParent;
            frmModal.ShowDialog(); // 모달창 열기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frmModaless = new Form();
            frmModaless.Text = "모달창";
            frmModaless.Width = 300;
            frmModaless.Height = 100;
            frmModaless.BackColor = Color.Red;
            // 모달리스창을 모달창처럼 메인창 정중앙에 위치하려면 계산 필요
            frmModaless.StartPosition = FormStartPosition.Manual;
            frmModaless.Location = new Point(this.Location.X + (this.Width - frmModaless.Width) / 2,
                                             this.Location.Y + (this.Height - frmModaless.Height) / 2);
            frmModaless.Show(this); // 모달창 열기
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // 메시지박스 -> 모달창
            MessageBox.Show(TxtResult.Text, "텍스트박스 문장", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            TrvDummy.Nodes.Add(rand.Next().ToString());
        }

        private void BtnNode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("노드를 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand(); // Expand()는 선택된 노드 확장, Collapse()는 축소
            TreeToList(); // 트리뷰를 리스트뷰로 변환
        }

        private void TreeToList()
        {
            LsvDummy.Items.Clear(); // 리스트뷰 초기화 
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            ListViewItem item = new ListViewItem(new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }); // 노드의 텍스트를 리스트뷰 아이템으로 추가
            item.ImageIndex = 0; // 아이템의 이미지인덱스를 지정
            LsvDummy.Items.Add(item);

            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode); // 재귀호출(Recursion Call)로 자식 노드 탐색
            }
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "이미지 열기";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                // OpenFileDialog에서 선택한 파일을 PictureBox에 표시
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom; // PictureVoxSize이미지 크기 조정
            }
        }

        private void CalSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(CalSchedule.SelectionStart.ToString());
            TxtYear.Text = CalSchedule.SelectionStart.Year.ToString();
            TxtMonth.Text = CalSchedule.SelectionStart.Month.ToString();
            TxtDay.Text = CalSchedule.SelectionStart.Day.ToString();
        }

        private void DtpBirth_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(DtpBirth.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing; // 폼클로징 이벤트를 제거
                //Application.Exit(); // 프로그램 완전 종료
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = true; // 종료 취소
            }
        }

        private void LblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://naver.com",   // 링크 주소
                UseShellExecute = true
            });
        }
    }
}
