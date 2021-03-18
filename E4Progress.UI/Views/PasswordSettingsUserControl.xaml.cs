using E4Progress.Shared.ViewModels;
using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for PasswordSettingsUserControl.xaml
    /// </summary>
    public partial class PasswordSettingsUserControl : UserControl
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public PasswordSettingsUserControl()
        {
            InitializeComponent();
        }

        private async void btnSavePassword_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var model = new ChangePasswordViewModel
            {
                Password = txtPassword.Password,
                NewPassword = txtNewPassword.Password,
                ConfirmPassword = txtConfirmPassword.Password,
                Email = config.AppSettings.Settings["Email"].Value
            };

            var jsonData = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var Language = config.AppSettings.Settings["Language"].Value;
            var response = await client.PostAsync($"https://localhost:44331/{Language}/api/User/ChangePassword", content);

            var responseBody = await response.Content.ReadAsStringAsync();
            if (responseBody.Contains("true"))
            {
                var responseObject = JsonConvert.DeserializeObject<AuthResultViewModel>(responseBody);

                if (responseObject.IsSuccess)
                {
                    LoginDialog dialog = new LoginDialog();
                    dialog.ShowDialog();
                }
            }else
            {
                txtMessage.Text = responseBody;
            }
        }
    }
}
