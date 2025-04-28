using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace WpfStudyApp04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> fruitItems { get; set; }
        public Dictionary<string, string> countryItems { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fruitItems = new ObservableCollection<String>
            {
                "용과",
                "망고스틴",
                "애플망고",
                "자몽",
                "두리안"
            };

            countryItems = new Dictionary<string, string>
            {
                { "KR", "대한민국" },
                { "US", "미국" },
                { "JP", "일본" },
                { "CN", "중국" },
                { "IN", "인도" },
                { "PH", "필리핀" }
            };  

            // 윈앱의 컨트롤.DataSource와 동일한 속성
            CboCollection.ItemsSource = fruitItems;

            LoadDivisionFromDatabase();

            // WPF xaml의 전체의 데이터 컨텍스트에 현재값을 바인딩
            // this.DataContext = this;와 동일한 기능
            // 대신 데이터를 전달하는 레벨은 다름
            this.DataContext = this;    // 반!드!시!
            //CboFruits.DataContext = this; // 조심해야함.
        }
        private void LoadDivisionFromDatabase()
        {
            // DB연결
            string connectionString = "Server=localhost;Database=bookrentalshop;Uid=root;Pwd=12345;Charset=utf8;";
            string query = "SELECT division, names FROM divtbl"; // 언어에서 쿼리 작성시는 ; 사용 안됨

            List<KeyValuePair<string, string>> divisions = new List<KeyValuePair<string, string>>();

            // DB연결, 처리, 할당. using을 쓰면 db.close()를 자동 실행
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // DB연결
                    MySqlCommand cmd = new MySqlCommand(query, conn); // 쿼리 실행을 위한 객체 생성
                    MySqlDataReader reader = cmd.ExecuteReader(); // 쿼리 실행
                    while (reader.Read())
                    {
                        var division = reader.GetString("division");    //reader.GetString(0); 는 지양
                        var names = reader.GetString("names");

                        divisions.Add(new KeyValuePair<string, string>(division, names));
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"DB연결 실패 : { ex.Message}", "DB연결 오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                //conn.Close(); // using을 사용하면 자동으로 close됨
            }   // 자동으로 conn.Close() 실행됨
            CboDivision.ItemsSource = divisions;
        }

        private void CboCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string value = ((KeyValuePair<string, string>)CboCountries.SelectedItem).Value;
            MessageBox.Show(value, "선택한 국가", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}