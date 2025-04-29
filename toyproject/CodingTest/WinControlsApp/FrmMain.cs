using System.Windows.Forms;
using System.IO;

namespace WinControlsApp2
{
    public partial class FrmMain : Form
    {
        int n = 0;
        int total = 0, correct = 0;
        int elapsedTime = 0; // 경과 시간(초)
        int[] correctAnswers = { 1, 3, 3, 1, 2, 1, 4, 2, 2, 4 }; // 문제별 정답 (1번, 3번, 2번, 4번)
        public FrmMain()
        {
            int n = 0; // 이미지 인덱스
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Images/waiting.png");
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string personalNum = TxtPersonalNumber.Text.Replace("-", ""); // 하이픈 제거
            string phoneNum = TxtPhoneNumber.Text.Replace("-", ""); // 하이픈 제거
            if (string.IsNullOrWhiteSpace(TxtName.Text) ||
               string.IsNullOrWhiteSpace(TxtPersonalNumber.Text) ||
               string.IsNullOrWhiteSpace(TxtPhoneNumber.Text))
            {
                MessageBox.Show("이름, 주민번호, 전화번호를 모두 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (personalNum.Length != 13)
            {
                MessageBox.Show("주민등록번호는 13자리 숫자만 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (phoneNum.Length != 11)
            {
                MessageBox.Show("전화번호는 11자리입니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (RdoMale.Checked == false && RdoFemale.Checked == false)
            {
                MessageBox.Show("성별을 선택하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                TxtResult.Text = "이름 : " + TxtName.Text + "\r\n" +
                                 "주민번호 : " + TxtPersonalNumber.Text + "\r\n" +
                                 "전화번호 : " + TxtPhoneNumber.Text + "\r\n" +
                                 "성별 : " + (RdoMale.Checked ? "남자" : "여자") + "\r\n" +
                                 "시험 과목 : " + CboTestName.Text + "\r\n" +
                                 "수험 번호 : " + CboTestNumber.Text + "\r\n";
            }
            BtnCheck.Enabled = false; // 버튼 비활성화
        }

        private void BtnCheck2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CboTestName.Text) ||
                 string.IsNullOrWhiteSpace(CboTestNumber.Text))
            {
                MessageBox.Show("시험 과목과 수험 번호를 모두 선택하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CboTestName.Text == "정보처리기사")
            {
                MessageBox.Show("응시가 가능합니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtResult.Clear();
                TxtResult.Text = "이름 : " + TxtName.Text + "\r\n" +
                                 "주민번호 : " + TxtPersonalNumber.Text + "\r\n" +
                                 "전화번호 : " + TxtPhoneNumber.Text + "\r\n" +
                                 "성별 : " + (RdoMale.Checked ? "남자" : "여자") + "\r\n" +
                                 "시험 과목 : " + CboTestName.Text + "\r\n" +
                                 "수험 번호 : " + CboTestNumber.Text + "\r\n";
                BtnCheck2.Enabled = false; // 버튼 비활성화
                n = 0; // 문제 인덱스 초기화
                pictureBox1.Image = imageList1.Images[n]; // 1번 문제 띄우기
                TxtResult.Text += "시험 시작\r\n";
                // 타이머 초기화 및 시작
                elapsedTime = 0;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("해당 시험은 준비중입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("정답입니다!", "정답", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correct++;
                TxtResult.Text += "문제 " + (n + 1) + " : 정답\r\n";
            }
            else
            {
                MessageBox.Show("오답입니다!", "오답", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtResult.Text += "문제 " + (n + 1) + " : 오답\r\n";
            }

            n++; // 다음 이미지 인덱스
            if (n >= imageList1.Images.Count)
            {
                MessageBox.Show($"총 {total}문제 중 {correct}문제를 맞췄습니다.", "종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("결과를 저장하시겠습니까?", "저장 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string filePath = "시험결과.txt";
                    File.WriteAllText(filePath, TxtResult.Text);
                    MessageBox.Show("결과가 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                pictureBox1.Image = imageList1.Images[n]; // 다음 이미지 보여줌}
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
