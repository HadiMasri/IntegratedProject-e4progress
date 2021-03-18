using E4Progress.Shared.ViewModels;
using E4Progress.UI.Extentions;
using E4Progress.UI.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;


namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for LoginDialog.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {
        public LoginDialog()
        {
            InitializeComponent();
            checkIfEmailAdressIsValid();
            GetLanguageAsync();
            CheckLanguage();
        }


        /// <summary>
        /// This method checks for the selected language
        /// from the language combobox and changes the UI
        /// to correspond to the selected language
        /// </summary>
        public void CheckLanguage()
        {
            if (cmbLanguage.SelectedIndex == 0)
            {
                btnLogin.Content = "Sign in";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(txtEmail, "Email");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(txtPassword, "Password");
            }
            if (cmbLanguage.SelectedIndex == 1)
            {
                btnLogin.Content = "Aanmelden";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(txtEmail, "E-mail");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(txtPassword, "Wachtwoord");
            }
            if (cmbLanguage.SelectedIndex == 2)
            {
                btnLogin.Content = "Se connecter";
                MaterialDesignThemes.Wpf.HintAssist.SetHint(txtEmail, "Email");
                MaterialDesignThemes.Wpf.HintAssist.SetHint(txtPassword, "Mot de passe");
            }
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        
            if (!Regex.IsMatch(txtEmail.Text, expression) || txtPassword.Password == "")
            {
                txtError.Text = "Check Your E-mail and Password if they correct !";
            } else
            {
                btnLogin.Visibility = Visibility.Hidden;
                spinner.Visibility = Visibility.Visible;
                var model = new LoginViewModel
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Password,

                };

                HttpClient client = new HttpClient();
                var jsonData = JsonConvert.SerializeObject(model);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:44331/en/api/User/Login", content);

                var responseBody = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<AuthResultViewModel>(responseBody);
                if (!responseObject.IsSuccess)
                {
                    txtError.Text = responseObject.Message;
                    btnLogin.Visibility = Visibility.Visible;
                    spinner.Visibility = Visibility.Hidden;
                }
                else
                {

                    Helper.RemoveUserInfo();
                    DeCodeJWT(responseObject.Token);
                    if (responseObject.IsSuccess)
                    {
                        Close();
                        MainWindow window = new MainWindow();
                        window.ShowDialog();
                    }
                    else
                    {
                        txtError.Text = responseObject.Message;
                        btnLogin.Visibility = Visibility.Visible;
                        spinner.Visibility = Visibility.Hidden;
                    }
                }

            }


        }
        public static void DeCodeJWT(string JWTToken)
        {

            // decode JWT Token to get user Info
            var stream = JWTToken;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = handler.ReadToken(stream) as JwtSecurityToken;

            var FirstName = tokenS.Payload["FirstName"];
            var LastName = tokenS.Payload["LastName"];
            var Email = tokenS.Payload["email"];
            var id = tokenS.Payload["UserId"];
            var language = tokenS.Payload["Language"];
            var languageId = tokenS.Payload["LanguageId"];
            
            var exp = tokenS.Claims.First(c => c.Type == "exp").Value;
            var role = tokenS.Claims.First(c => c.Type.Contains("role")).Value;
            //var id = tokenS.Claims.First(c => c.Type == "UserId").Value;



            // Set userInfo to AppSetting

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
         
            config.AppSettings.Settings.Add("Token", JWTToken);
            config.AppSettings.Settings.Add("FirstName", FirstName.ToString());
            config.AppSettings.Settings.Add("LastName", LastName.ToString());
            config.AppSettings.Settings.Add("Email", Email.ToString());
            config.AppSettings.Settings.Add("exp", exp);
            config.AppSettings.Settings.Add("role", role);
            config.AppSettings.Settings.Add("id", id.ToString());
            config.AppSettings.Settings.Add("Language", language.ToString());
            config.AppSettings.Settings.Add("languageId", languageId.ToString());
            //var x = config.AppSettings.Settings["Token"];
            config.Save(ConfigurationSaveMode.Modified);
 
        }

        public async void GetLanguageAsync()
        {
            List<LanguageViewModel> language = await HttpClientHelper<LanguageViewModel>.HttpClientGetAsync("Language");
            cmbLanguage.ItemsSource = language;
            cmbLanguage.ItemsSource = language;
        }

        public void ChangeLanguage(string email,int languageId)
        {
            var user = services.service.GetUserByEmail(email).Result;
            user.LanguageId = languageId;
             services.service.ChangeLanguage(user);
        }

        private void cmbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int langaugeid;
            if (cmbLanguage.SelectedValue == null)
            {
                langaugeid = 1;
            }
            else
            {
                langaugeid = (int)cmbLanguage.SelectedValue;
            }
         
            ChangeLanguage(txtEmail.Text, langaugeid);

            CheckLanguage();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cmbLanguage != null)
            {
                checkIfEmailAdressIsValid();
            }
        }

        private bool checkIfEmailAdressIsValid()
        {
            bool result = ValidatorExtensions.IsValidEmailAddress(txtEmail.Text);

            if (!result)
            {
                cmbLanguage.IsEnabled = false;
            }
            else
            {

                cmbLanguage.IsEnabled = true;
            }
            return result;
        }
    }
}
