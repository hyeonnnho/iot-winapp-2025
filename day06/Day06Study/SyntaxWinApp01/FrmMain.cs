using System.ComponentModel;    // ��׶��� ��Ŀ �̺�Ʈ �ƱԸ�Ʈ ���ӽ����̽�
namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // ��׶��� ��Ŀ �ʱ�ȭ
            BgwProcess.WorkerReportsProgress = true;    // ������� ����Ʈ�� ������

            BgwProcess.DoWork += BgwProcess_DoWork;     // ��׶��� ���� �̺�Ʈ
            BgwProcess.ProgressChanged += BgwProcess_ProgressChanged;   // ��׶��� ���� ���� ���� �̺�Ʈ UI
            BgwProcess.RunWorkerCompleted += BgwProcess_RunWorkerCompleted; // ��׶��� �۾� �Ϸ� �̺�Ʈ

            // ��ư Ŭ�� �̺�Ʈ
            BtnStart.Click += BtnStart_Click; // ���� ��ư Ŭ�� �̺�Ʈ
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            LblState.Text = "������� : ����";
            BtnStart.Text = "������";
            BtnStart.Enabled = false; // ��ư ��Ȱ��ȭ

            PrgProcess.Minimum = 0; // �ּҰ�
            PrgProcess.Maximum = 100; // �ִ밪
            PrgProcess.Value = 0; // ���簪

            TxtLog.Clear(); // �α� �ʱ�ȭ

            BgwProcess.RunWorkerAsync(); // ��׶��� ��Ŀ ����
        }

        // ��׶��� ���� �۾�
        private void BgwProcess_DoWork(object? sender, DoWorkEventArgs e)
        {
            long MaxVal = 200;
            long total = 0;
            
            for (int i = 0; i < MaxVal; i++)
            {
                total += i % 3; // ���������� ������ ó��

                int progress = (int)((i * 100) / MaxVal) + 1;
                // ���� ������ ProgressChanged �̺�Ʈ ������ ����
                BgwProcess.ReportProgress(progress, i);

                Thread.Sleep(50); // ���ſ� �۾� �䳻

            }
        }
        // ���� ���� UI ������Ʈ
        private void BgwProcess_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage; // DoWork.ReportProgress(1, 2) �� 1������ �Ѿ�� ��
            int currVal = (int)e.UserState; // DoWork.ReportProgress(1, 2) �� 2������ �Ѿ�� ��

            PrgProcess.Value = progress; // ���� ���� ������Ʈ

            TxtLog.AppendText(currVal.ToString() + "\r\n");
            TxtLog.SelectionStart = TxtLog.Text.Length;
            TxtLog.ScrollToCaret();

            LblState.Text = $"������� : {progress}%";
        }
        // ��׶��� �۾� �Ϸ� �� ó�� �̺�Ʈ
        private void BgwProcess_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            LblState.Text = "������� : �Ϸ�";
            BtnStart.Enabled = true; // ��ư Ȱ��ȭ
            BtnStart.Text = "����";
        }
    }
} 
