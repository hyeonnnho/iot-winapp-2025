namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int add(int x, int y)
        {
            return x + y;
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 20);

            // delegate = ���ٽ� (x, y) => x + y
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 30) + "\r\n";

            // SayHello �Լ� ���� ���
            Action<string> sayHello = (name) => MessageBox.Show($"�ȳ�, {name}", "�޽���", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            sayHello("����ȣ");

            // LINQ ��� ����
            List<int> resList = new List<int>();
            List<int> numbers = [4, 10, 1, 5, 9, 8, 6, 2, 3, 7];

            // ¦���� �����ؼ� �������� ���� �ϴ� ����
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    resList.Add(n);
                }
            }
            TxtLog.Text += "���� ¦������Ʈ > " + string.Join(" ", resList) + "\r\n";

            resList.Sort();

            TxtLog.Text += "���� ���ĸ���Ʈ > " + string.Join(" ", resList) + "\r\n";

            // LINQ ��� > 3�ٷ� ���� �������� ó��
            numbers = [14, 20, 11, 15, 18, 19, 16, 13, 12, 17];
            var resList2 = from n in numbers
                           where n % 2 == 0
                           orderby n ascending
                           select n;
            TxtLog.Text += "LINQ ���ĸ���Ʈ > " + string.Join(" ", resList2) + "\r\n";

            // LINQ Method Chaining
            numbers = [24, 30, 21, 25, 28, 29, 26, 23, 22, 27];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "LINQ Method Chaining ���ĸ���Ʈ > " + string.Join(" ", resList3) + "\r\n";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // UI �ʱ�ȭ
            TxtTest.PlaceholderText = "�׽�Ʈ�Դϴ�";
            TxtTest.Size = new Size(200, 23);
            TxtTest.KeyPress += TxtTest_KeyPress;   // Designer���� �۾��ϴ� �Ͱ� ����
            TxtTest.Font = new Font("�޸ո���ü", 12, FontStyle.Italic);
        }

        private void TxtTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // == 13�� ����
            {
                MessageBox.Show("Enter Key Pressed", "Keypress", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            // �⺻
            Print<int>(100);
            Print<float>(3.141592f);
            Print<string>("Hello, World");
            Print<bool>(true);

            // �������� - ���Ǽ��� ���ؼ�
            Print(200);
            Print(6.141592f);
            Print("�ȳ��ϼ���");
            Print(false);

            // ���׸� Ŭ���� ���
            Box<int> intBox = new Box<int>();
            intBox.Value = 300;
            intBox.Show();

            Box<string> strBox = new Box<string>();
            strBox.Value = "������� ����";
            strBox.Show();
        }

        public void Print<T>(T data) { Console.WriteLine(data); }
    }

    // ���׸� Ŭ����
    public class Box<T> // where T : struct
    {
        public T Value { get; set; }    // �Ӽ�
        //private T value; // �������

        public void Show()
        {
            Console.WriteLine($"Box�� �� : {Value}", "Box��", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
