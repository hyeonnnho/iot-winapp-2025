namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // async : 비동기로 동작하는 메서드라고 선언
        // async, await는 항상 같이 사용
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "현재상태 : 진행";    // UI처리
            BtnStart.Text = "진행중";  // UI처리
            BtnStart.Enabled = false; // 못쓰게함

            // 엄청난 시간이 걸리는 연산을 수행
            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0;  // UI처리
            PrgProcess.Maximum = 100;  // UI처리

            // await로 비동기 대기
            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;
                    int progress = (int)((i * 100) / MaxVal) + 1;
                    Console.WriteLine(progress.ToString());
                    // Task.Run 내에 들어가는 UI처리하는 로직은
                    this.Invoke(new Action(() =>
                    {
                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length; // 커서를 맨 뒤로 이동
                        TxtLog.ScrollToCaret(); // 스크롤을 맨 아래로 이동
                        PrgProcess.Value = progress; // UI처리
                    })); // UI처리

                    Thread.Sleep(50); // 50ms 동안 대기(대량의 일을 처리하는 것처럼)
                }
            });

            //for (int i = 0; i < MaxVal; i++)
            //{
            //    total += i % 3;
            //    int progress = (int)((i * 100) / MaxVal) + 1;
            //    Console.WriteLine(progress.ToString());
            //    TxtLog.Text += i.ToString() + "\r\n";
            //    TxtLog.SelectionStart = TxtLog.Text.Length; // 커서를 맨 뒤로 이동
            //    TxtLog.ScrollToCaret(); // 스크롤을 맨 아래로 이동
            //    PrgProcess.Value = progress; // UI처리

            //    Thread.Sleep(50); // 50ms 동안 대기(대량의 일을 처리하는 것처럼)
            //    //Application.DoEvents(); // 권장x
            //}

            LblCurrState.Text = "현재상태 : 중지";  // UI처리
            BtnStart.Text = "시작";  // UI처리
            BtnStart.Enabled = true; // 다시 사용 가능
        }

        private void PrgProcess_Click(object sender, EventArgs e)
        {

        }
    }
}
