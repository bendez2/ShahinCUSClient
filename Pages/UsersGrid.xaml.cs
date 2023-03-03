using Newtonsoft.Json;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;

namespace Nastol
{
    /// <summary>
    /// Логика взаимодействия для UsersGrid.xaml
    /// </summary>
    public partial class UsersGrid : Window
    {

        public UsersGrid()
        {

            InitializeComponent();
            TableInfo();
           
        }

         private async void TableInfo()
        {
            string url = "https://apis.api-mauijobs.site/Users";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            HttpContent responseContent = response.Content;
            var a = await responseContent.ReadAsStringAsync();

            User[] UserItems = JsonConvert.DeserializeObject<User[]>(a);

            UGrid.ItemsSource = UserItems;
            
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Menu window = new Menu();
            window.Show();
            this.Close();
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            TableInfo();
        }

        private void CellClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window Window = new ChangeUser((User)UGrid.CurrentItem);
            Window.Show();
            Close();
        }
    }
}
