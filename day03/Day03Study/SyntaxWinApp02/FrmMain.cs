using SyntaxWinApp02.Properties;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Computer mycom = new Computer();

            //Notebook myNotebook = new Notebook();

            //Server yourServer = new Server();

            //Computer yourCom = new Notebook();  // �θ�Ŭ������ �ڽ� ��ü�� �Ҵ�

            switch (CboDivision.SelectedIndex)
            {
                case 0: // Computer
                    Computer mycom = new Computer();
                    PicComputer.Image = Resources.computer_case;

                    mycom.Boot();
                    mycom.Reset();
                    mycom.ShutDown();
                    break;
                case 1: // Notebook
                    Notebook myNotebook = new Notebook();
                    PicComputer.Image = Resources.laptop;

                    myNotebook.Reset();
                    myNotebook.ShutDown();  //  �θ�� �ٸ��� ����

                    //Computer sCom = myNotebook;
                    // �θ� Ŭ������ �ڽ� Ŭ������ ����ȯ�ϸ鼭 �����߻� ����
                    //Notebook myNotebook2 = (Notebook)new Computer();
                    Computer myComputer = new Notebook();

                    if (myComputer is Notebook)
                    {
                        Console.WriteLine("myComputer�� Notebook�Դϴ�.");
                        Notebook myNotebook2 = myComputer as Notebook;
                        Console.WriteLine("myComputer�� Notebook���� ����!");
                    }

                    // �����ν� Ȯ��
                    bool hasFinger = myNotebook.HasFingerScanDevice();
                    Console.WriteLine($"�����νĿ��� :: {hasFinger}");
                    // �޼��� �����ε�
                    hasFinger = myNotebook.HasFingerScanDevice(true);
                    Console.WriteLine($"�����νĿ��� :: {hasFinger}");

                    break;
                case 2: // Server
                    Server yourServer = new Server();
                    PicComputer.Image = Resources.server;
                    break;
                default:
                    break;
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Server server1 = new Server();
            server1.Name = "HP����";

            // ���� ���� : ���� ���� ����
            Server server2 = server1;  
            server2.Name = "DELL����";

            bool isSame = server1.Equals(server2);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server2.Name}\r\n", "������");

            // ���� ���� : ���� �ٸ� ��ü�� ����
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL����";

            isSame = server1.Equals(server3);
            Console.WriteLine(isSame);
            
            MessageBox.Show($"{server1.Name}\r\n{server3.Name}\r\n", "������");
        }
    }
}
