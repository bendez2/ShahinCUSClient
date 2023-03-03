using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;

namespace Nastol
{

    public partial class ChangeUser : Window
    {
        RequestApi requestApi = new RequestApi();
        private User _user;

        public ChangeUser(User user)
        {
            InitializeComponent();
            _user = user;
            UpdateUser();
        }

        private void UpdateUser()
        {
            TextLogin.Text = _user.Login;
            TextPass.Text = _user.Password;
            TextName.Text = _user.Name;
            TextSurname.Text = _user.Surname;
            TextPatronomic.Text = _user.Patronomic;
            TextDateofBirth.Text = _user.DateofBirth;
            TextEnterprice.Text = _user.Enterprice;
        }

        private void BackButt_Click(object sender, RoutedEventArgs e)
        {
            Window secondWindow = new UsersGrid();
            secondWindow.Show();
            Close();
        }

        private async void SaveData(object sender, RoutedEventArgs e)
        {
            SaveButt.IsEnabled = false;

            _user.Login = TextLogin.Text;
            _user.Name = TextName.Text;
            _user.Surname = TextSurname.Text;
            _user.Patronomic = TextPatronomic.Text;
            _user.DateofBirth = TextDateofBirth.Text;
            _user.Enterprice = TextEnterprice.Text;

            string jsonUser = JsonConvert.SerializeObject(_user);
            string updatedUser = await requestApi.SendAPutRequestAsync("Users", jsonUser);
            
            if (updatedUser != null)
            {
                Window Window = new UsersGrid();
                Window.Show();
                Close();
            }
            else
            {
                MessageBox.Show(" Ошибка", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                SaveButt.IsEnabled = true;
            }
        }
    }
}
