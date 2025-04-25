using System.Windows.Forms;

namespace WinControlsApp2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            int n = 0; // �̹��� �ε���
            pictureBox1.Image = imageList1.Images[n]; // 0�� �̹��� ������
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "�̸� : " + TxtName.Text + "\r\n" +
                             "�ֹι�ȣ : " + TxtPersonalNumber.Text + "\r\n" +
                             "��ȭ��ȣ : " + TxtPhoneNumber.Text + "\r\n" +
                             "���� : " + (RdoMale.Checked ? "����" : "����") + "\r\n";
        }

        private void BtnCheck2_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "���� ���� : " + CboTestName.Text + "\r\n" +
                             "���� ��ȣ : " + CboTestNumber.Text + "\r\n";
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            int Answer = 0;
            if (Rdo1.Checked) Answer = 1;
            else if (Rdo2.Checked) Answer = 2;
            else if (Rdo3.Checked) Answer = 3;
            else if (Rdo4.Checked) Answer = 4;

            Rdo1.Checked = false;
            Rdo2.Checked = false;
            Rdo3.Checked = false;
            Rdo4.Checked = false;

            if (Answer == 1)
            {
                MessageBox.Show("�����Դϴ�!", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("�����Դϴ�!", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            n++; // ���� �̹��� �ε���
            pictureBox1.Image = imageList1.Images[n]; // ���� �̹��� ������
        }

    }
}
