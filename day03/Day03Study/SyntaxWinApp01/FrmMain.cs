namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // �⺻ ������
            Person haeno = new Person();
            haeno.Name = TxtName.Text.Trim();
            haeno.Age = int.Parse(TxtAge.Text.Trim());  // ���ڿ��� ������
            haeno.Gender = char.Parse(TxtGender.Text);
            haeno.Phone = TxtPhone.Text.Trim();
            // �Ű����� ������
            Person ashely = new Person("�ֽ���", 42, 'F', "010-3333-4444");

            TxtResult.Text = haeno.ToString();
            haeno.Getup();
            haeno.GoToSchool();
            
            // static�� ���� ��ü�� �������� ����
            Person.GetNumber();
        }
    }
}
