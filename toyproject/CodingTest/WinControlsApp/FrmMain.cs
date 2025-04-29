using System.Windows.Forms;
using System.IO;

namespace WinControlsApp2
{
    public partial class FrmMain : Form
    {
        int n = 0;
        int total = 0, correct = 0;
        int elapsedTime = 0; // ��� �ð�(��)
        int[] correctAnswers = { 1, 3, 3, 1, 2, 1, 4, 2, 2, 4 }; // ������ ���� (1��, 3��, 2��, 4��)
        public FrmMain()
        {
            int n = 0; // �̹��� �ε���
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Images/waiting.png");
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string personalNum = TxtPersonalNumber.Text.Replace("-", ""); // ������ ����
            string phoneNum = TxtPhoneNumber.Text.Replace("-", ""); // ������ ����
            if (string.IsNullOrWhiteSpace(TxtName.Text) ||
               string.IsNullOrWhiteSpace(TxtPersonalNumber.Text) ||
               string.IsNullOrWhiteSpace(TxtPhoneNumber.Text))
            {
                MessageBox.Show("�̸�, �ֹι�ȣ, ��ȭ��ȣ�� ��� �Է��ϼ���.", "�Է� ����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (personalNum.Length != 13)
            {
                MessageBox.Show("�ֹε�Ϲ�ȣ�� 13�ڸ� ���ڸ� �Է��ϼ���.", "�Է� ����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (phoneNum.Length != 11)
            {
                MessageBox.Show("��ȭ��ȣ�� 11�ڸ��Դϴ�.", "�Է� ����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (RdoMale.Checked == false && RdoFemale.Checked == false)
            {
                MessageBox.Show("������ �����ϼ���.", "�Է� ����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                TxtResult.Text = "�̸� : " + TxtName.Text + "\r\n" +
                                 "�ֹι�ȣ : " + TxtPersonalNumber.Text + "\r\n" +
                                 "��ȭ��ȣ : " + TxtPhoneNumber.Text + "\r\n" +
                                 "���� : " + (RdoMale.Checked ? "����" : "����") + "\r\n" +
                                 "���� ���� : " + CboTestName.Text + "\r\n" +
                                 "���� ��ȣ : " + CboTestNumber.Text + "\r\n";
            }
            BtnCheck.Enabled = false; // ��ư ��Ȱ��ȭ
        }

        private void BtnCheck2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CboTestName.Text) ||
                 string.IsNullOrWhiteSpace(CboTestNumber.Text))
            {
                MessageBox.Show("���� ����� ���� ��ȣ�� ��� �����ϼ���.", "�Է� ����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CboTestName.Text == "����ó�����")
            {
                MessageBox.Show("���ð� �����մϴ�.", "Ȯ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtResult.Clear();
                TxtResult.Text = "�̸� : " + TxtName.Text + "\r\n" +
                                 "�ֹι�ȣ : " + TxtPersonalNumber.Text + "\r\n" +
                                 "��ȭ��ȣ : " + TxtPhoneNumber.Text + "\r\n" +
                                 "���� : " + (RdoMale.Checked ? "����" : "����") + "\r\n" +
                                 "���� ���� : " + CboTestName.Text + "\r\n" +
                                 "���� ��ȣ : " + CboTestNumber.Text + "\r\n";
                BtnCheck2.Enabled = false; // ��ư ��Ȱ��ȭ
                n = 0; // ���� �ε��� �ʱ�ȭ
                pictureBox1.Image = imageList1.Images[n]; // 1�� ���� ����
                TxtResult.Text += "���� ����\r\n";
                // Ÿ�̸� �ʱ�ȭ �� ����
                elapsedTime = 0;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("�ش� ������ �غ����Դϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboTestName.SelectedIndex = -1;
            }
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

            total++;
            if (Answer == correctAnswers[n])
            {
                MessageBox.Show("�����Դϴ�!", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correct++;
                TxtResult.Text += "���� " + (n + 1) + " : ����\r\n";
            }
            else
            {
                MessageBox.Show("�����Դϴ�!", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtResult.Text += "���� " + (n + 1) + " : ����\r\n";
            }

            n++; // ���� �̹��� �ε���
            if (n >= imageList1.Images.Count)
            {
                MessageBox.Show($"�� {total}���� �� {correct}������ ������ϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("����� �����Ͻðڽ��ϱ�?", "���� Ȯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string filePath = "������.txt";
                    File.WriteAllText(filePath, TxtResult.Text);
                    MessageBox.Show("����� ����Ǿ����ϴ�.", "���� �Ϸ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                pictureBox1.Image = imageList1.Images[n]; // ���� �̹��� ������}
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            int minutes = elapsedTime / 60;
            int seconds = elapsedTime % 60;
            lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }
    }
}
