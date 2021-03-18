using E4Progress.DAL.Entities;
using E4Progress.Shared.ViewModels;
using E4Progress.UI.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for UsersUserControl.xaml
    /// </summary>
    public partial class UsersUserControl : UserControl
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        UsersUserControlViewModel usersUserControlViewModel = new UsersUserControlViewModel();
        public UsersUserControl()
        {
            InitializeComponent();
            cmbRole.ItemsSource = GetRole().Result;

        }

        private async void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password != txtConfirmPassword.Password)
            {
                txtMessage.Text = usersUserControlViewModel.RegisterMessagePasswordNotMatch;
            }
            else
            {

                HttpClient client = new HttpClient();
                var model = new RegisterUserViewModel
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Password,
                    ConfirmPassword = txtConfirmPassword.Password,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    RoleId = (int)cmbRole.SelectedValue


                };
                string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(txtEmail.Text, expression))
                {
                    var jsonData = JsonConvert.SerializeObject(model);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", config.AppSettings.Settings["Token"].Value);
                    var Language = config.AppSettings.Settings["Language"].Value;
                    var response = await client.PostAsync($"https://localhost:44331/{Language}/api/User/Register", content);

                    var responseBody = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<AuthResultViewModel>(responseBody);

                    if (responseObject.IsSuccess)
                    {
                        //txtMessage.Text = responseObject.Message;
                        txtMessage.Text = usersUserControlViewModel.RegisterSuccessMesssage;
                    }
                    else
                    {
                        //txtMessage.Text = responseObject.Message;
                        txtMessage.Text = usersUserControlViewModel.RegisterDuplicateEmailMesssage;
                    }
                }
                else
                {
                    txtMessage.Text = usersUserControlViewModel.InValidEmail;
                }
             
            }

        }

        private async Task<List<Role>> GetRole()
        {
          var userRoles =  await services.service.GetRole();
           return userRoles;

        }
        /// <summary>
        /// Letter validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lettersValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
