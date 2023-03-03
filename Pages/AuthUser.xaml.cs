using Newtonsoft.Json;
using System.Windows;

namespace Nastol
{
    public partial class AuthUser : Window
    {
        RequestApi requestApi = new RequestApi();

        public AuthUser()
        {
            InitializeComponent();
        }

        private async void AuthClick(object sender, RoutedEventArgs e)
        {
            AuthButt.IsEnabled = false;

            string json = JsonConvert.SerializeObject(new User()
            {
                ID = 0,
                Login = LoginUser.Text,
                Password = HashingString.HashingPassword(PassUser.Password),
                Enterprice = "",
                Surname = "",
                Name = "",
                Patronomic = "",
                DateofBirth = "",
                RoleId = 0
            });

            string authUser = await requestApi.SendAPostRequstAsync("Authorization", json);

            if (authUser != null)
            {
                CurrentUser.user = JsonConvert.DeserializeObject<User>(authUser);
                Window secondWindow = new Menu();
                string asd = await requestApi.SendAGetRequstAsync("Authorization", CurrentUser.user.ID); 
                secondWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show(" Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                AuthButt.IsEnabled = true;
            }
        }
    }
}
