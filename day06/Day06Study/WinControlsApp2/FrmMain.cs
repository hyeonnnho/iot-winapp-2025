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
            int n = 0; // 이미지 인덱스
            pictureBox1.Image = imageList1.Images[n]; // 0번 이미지 보여줌
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "이름 : " + TxtName.Text + "\r\n" +
                             "주민번호 : " + TxtPersonalNumber.Text + "\r\n" +
                             "전화번호 : " + TxtPhoneNumber.Text + "\r\n" +
                             "성별 : " + (RdoMale.Checked ? "남자" : "여자") + "\r\n";
        }

        private void BtnCheck2_Click(object sender, EventArgs e)
        {
            TxtResult.Text += "시험 과목 : " + CboTestName.Text + "\r\n" +
                             "수험 번호 : " + CboTestNumber.Text + "\r\n";
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
                MessageBox.Show("정답입니다!", "정답", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("오답입니다!", "오답", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            n++; // 다음 이미지 인덱스
            pictureBox1.Image = imageList1.Images[n]; // 다음 이미지 보여줌
        }

    }
}
