namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        // �븮��(delegate) ����
        delegate void MyDelegate(string msg);
        // �̺�Ʈ
        delegate void MyEventHandler(object sender, EventArgs e);
        // �̺�Ʈ ����
        public event EventHandler SomethingHappened;  // �̺�Ʈ ����
        // �븮�ڿ��� ȣ���� �޼��� : �븮�ڿ� �Ķ���Ͱ� ��ġ�ؾ� ��
        void SayHello(string msg)
        {
            MessageBox.Show($"�ȳ�, {msg}", "�޽���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SayGoodbye(string msg)
        {
            MessageBox.Show($"�߰�, {msg}", "�޽���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FrmMain()
        {
            InitializeComponent();
            TxtLog.Text += ("1. �� ������ ����\r\n");
            Console.WriteLine("1. �� ������ ����");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TxtLog.Text += ("2. ���ε� �̺�Ʈ ����\r\n");
            Console.WriteLine("2. ���ε� �̺�Ʈ ����");
        }
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            TxtLog.Text += ("4. ���� �̺�Ʈ ����\r\n");
            Console.WriteLine("4. ���� �̺�Ʈ ����");
        }
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            TxtLog.Text += ("3. ����Ƽ����Ʈ �̺�Ʈ ����\r\n");
            Console.WriteLine("3. ����Ƽ����Ʈ �̺�Ʈ ����");
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TxtLog.Text += ("5. ��Ŭ��¡ �̺�Ʈ ����\r\n");
            Console.WriteLine("5. ��Ŭ��¡ �̺�Ʈ ����");
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            TxtLog.Text += ("6. ��Ŭ����� �̺�Ʈ ����\r\n");
            Console.WriteLine("6.��Ŭ����� �̺�Ʈ ����");
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 1. ���� �޼��� ȣ��
            SayHello("ȫ�浿");
            SayGoodbye("ȫ�浿");  // �޼��带 ���� ȣ��

            // 2. �븮��(delegate) ȣ��(���� ���� �ٽ�!!)
            MyDelegate del = SayHello;  // �븮�ڿ� ȣ���� �޼��带 ������
            del += SayGoodbye;  // �߰� ����(�븮�� ü�� �߰�)
            del -= SayHello;  // ���� ����(�븮�� ü�� ����)
            del("�̼���");  // �븮�� ȣ��

            // 3. ��ȯ�� ���� �븮�� - Action
            Action<string> act = SayHello;
            act("����");

            // 4. ��ȯ�� �ִ� �븮�� - Func
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(7, 8);
            Console.WriteLine(result);

            if (SomethingHappened != null)
            {
                SomethingHappened(this, new EventArgs());  // �̺�Ʈ �߻�
            }
            else
            {
                MessageBox.Show("�̺�Ʈ�� �����ϴ�.");
            }
        }

    }
}
