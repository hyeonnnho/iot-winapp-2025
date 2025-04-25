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
            // OS ��ü ��Ʈ ��������
            var Fonts = FontFamily.Families;
            // ��Ʈ �޺��ڽ��� �߰�
            //CboFonts.Items.AddRange(Fonts);
            foreach (var font in Fonts)
            {
                CboFonts.Items.Add(font.Name);
            }

            LblState.Text = "���� : ��Ʈ �б� �Ϸ�";

            toolTip1.SetToolTip(BtnModal, "���â ���� ��ư"); // ���� 
            toolTip1.SetToolTip(TxtYear, "�޷� ���� �⵵ ǥ�� �ؽ�Ʈ �ڽ�"); // ����
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
            if (CboFonts.SelectedIndex < 0) return; // ���õ� ��Ʈ�� ������ ����

            FontStyle style = FontStyle.Regular; // 0 ��ſ� Regular�� ���

            if (ChkBold.Checked)
                style |= FontStyle.Bold; // FontStyle.Regular | Fontstyle.Bold => 0000 | 0001 => 0001

            if (ChkItalic.Checked)
                style |= FontStyle.Italic; // FontStyle.Regular | Fontstyle.Italic => 0001 | 0010 => 0011

            // CobFonts���� ���õ� ���ڷ�, ����ũ�� 12, ����ü ��Ÿ�� ����
            TxtResult.Font = new Font((string)CboFonts.SelectedItem, 12, style); // ��Ʈ ũ�� 12�� ����
        }

        private void TrbProcess_Scroll(object sender, EventArgs e)
        {
            PrgProcess.Value = TrbProcess.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "���â";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Red;
            frmModal.StartPosition = FormStartPosition.CenterParent;
            frmModal.ShowDialog(); // ���â ����
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frmModaless = new Form();
            frmModaless.Text = "���â";
            frmModaless.Width = 300;
            frmModaless.Height = 100;
            frmModaless.BackColor = Color.Red;
            // ��޸���â�� ���âó�� ����â ���߾ӿ� ��ġ�Ϸ��� ��� �ʿ�
            frmModaless.StartPosition = FormStartPosition.Manual;
            frmModaless.Location = new Point(this.Location.X + (this.Width - frmModaless.Width) / 2,
                                             this.Location.Y + (this.Height - frmModaless.Height) / 2);
            frmModaless.Show(this); // ���â ����
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // �޽����ڽ� -> ���â
            MessageBox.Show(TxtResult.Text, "�ؽ�Ʈ�ڽ� ����", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("��带 �����ϼ���", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand(); // Expand()�� ���õ� ��� Ȯ��, Collapse()�� ���
            TreeToList(); // Ʈ���並 ����Ʈ��� ��ȯ
        }

        private void TreeToList()
        {
            LsvDummy.Items.Clear(); // ����Ʈ�� �ʱ�ȭ 
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            ListViewItem item = new ListViewItem(new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }); // ����� �ؽ�Ʈ�� ����Ʈ�� ���������� �߰�
            item.ImageIndex = 0; // �������� �̹����ε����� ����
            LsvDummy.Items.Add(item);

            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode); // ���ȣ��(Recursion Call)�� �ڽ� ��� Ž��
            }
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "�̹��� ����";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                // OpenFileDialog���� ������ ������ PictureBox�� ǥ��
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom; // PictureVoxSize�̹��� ũ�� ����
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
            //MessageBox.Show(DtpBirth.Value.ToString(), "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing; // ��Ŭ��¡ �̺�Ʈ�� ����
                //Application.Exit(); // ���α׷� ���� ����
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("�����Ͻðڽ��ϱ�?", "���Ῡ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = true; // ���� ���
            }
        }

        private void LblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://naver.com",   // ��ũ �ּ�
                UseShellExecute = true
            });
        }
    }
}
