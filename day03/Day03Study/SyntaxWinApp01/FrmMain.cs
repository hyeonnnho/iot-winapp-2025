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
            // 기본 생성자
            Person haeno = new Person();
            haeno.Name = TxtName.Text.Trim();
            haeno.Age = int.Parse(TxtAge.Text.Trim());  // 문자열을 정수로
            haeno.Gender = char.Parse(TxtGender.Text);
            haeno.Phone = TxtPhone.Text.Trim();
            // 매개변수 생성자
            Person ashely = new Person("애슐리", 42, 'F', "010-3333-4444");

            TxtResult.Text = haeno.ToString();
            haeno.Getup();
            haeno.GoToSchool();
            
            // static일 경우는 객체를 생성하지 않음
            Person.GetNumber();
        }
    }
}
