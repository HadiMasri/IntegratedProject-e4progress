using E4Progress.DAL.Entities;
using E4Progress.Shared.ViewModels;
using E4Progress.UI.ViewModelsdata;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace E4Progress.UI.services
{
    public static class service
    {
        public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        #region 
        //Role Region
        public static async Task<List<Role>> GetRole()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var result = new List<Role>();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", config.AppSettings.Settings["Token"].Value);
            client.BaseAddress = new Uri("https://localhost:44331/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var Language = "";
            if (config.AppSettings.Settings["Language"] == null)
            { Language = "en"; }
            else { Language = config.AppSettings.Settings["Language"].Value; }
            HttpResponseMessage response = client.GetAsync($"{Language}/api/User/Role").Result;
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<Role>>(responseBody);
            }
            return result;

        }

        public static async Task<List<UserRolesViewModel>> GetUserRoleByUserId(int userId)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var result = new List<UserRolesViewModel>();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", config.AppSettings.Settings["Token"].Value);
            client.BaseAddress = new Uri("https://localhost:44331/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = new HttpResponseMessage();
            var Language = "";
            if (config.AppSettings.Settings["Language"] == null)
            { Language = "en"; }
            else { Language = config.AppSettings.Settings["Language"].Value; }
            response = client.GetAsync($"{Language}/api/User/UserRoles?userId={userId}").Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<UserRolesViewModel>>(responseBody);
            }
            return result;
        }
        #endregion

        #region
        // User Role 

        public static async Task AsigneRoleToUser(UserRoleViewModel userRole)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string Language = "";
            if (config.AppSettings.Settings["Language"].Value == null)
            {
                Language = "en";
            }
            else
            {
                Language = config.AppSettings.Settings["Language"].Value;
            }
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Post, $"https://localhost:44331/{Language}/api/UserRole/AsigneRoleToUser"))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", config.AppSettings.Settings["Token"].Value);
                var json = JsonConvert.SerializeObject(userRole);
                using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    request.Content = stringContent;

                    using (var response = await client
                        .SendAsync(request, HttpCompletionOption.ResponseHeadersRead)
                        .ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();

                    }
                }
            }
        }


        public static async Task EndRoleAsync(int roleId ,int userId, string pathName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string Language = "";
            if (config.AppSettings.Settings["Language"].Value == null)
            {
                Language = "en";
            }
            else
            {
                Language = config.AppSettings.Settings["Language"].Value;
            }
            string Url = $"https://localhost:44331/{Language}/api/UserRole/{pathName}/{roleId}/{userId}";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // Post the JSON and wait for a response.
            HttpResponseMessage httpResponseMessage = await client.DeleteAsync(Url);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                httpResponseMessage.StatusCode.ToString();
            }
        }

        #endregion
        // User

        public static async Task<List<UserViewModel>> GetUser()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var users = new List<UserViewModel>();
            UserViewModel user;
            var result = new List<User>();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", config.AppSettings.Settings["Token"].Value);
            client.BaseAddress = new Uri("https://localhost:44331/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var Language = "";

            if (config.AppSettings.Settings["Language"] == null)
            { Language = "en"; }
            else { Language = config.AppSettings.Settings["Language"].Value; }
            HttpResponseMessage response = client.GetAsync($"{Language}/api/User/Users").Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<User>>(responseBody);

                foreach (var item in result)
                {
                    user = new UserViewModel
                    {
                        Id = item.Id,
                        Name = $"{item.Firstname} {item.Lastname}"
                    };
                    users.Add(user);
                }
            }

            return users;
        }


        public static async Task<UserViewModelFull> GetUserByEmail(string email)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var result = new UserViewModelFull();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44331/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var Language = "";

            if (config.AppSettings.Settings["Language"] == null)
            { Language = "en"; }
            else { Language = config.AppSettings.Settings["Language"].Value; }
            HttpResponseMessage response = client.GetAsync($"{Language}/api/User/UserByEmail/" + email).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<UserViewModelFull>(responseBody);
            }

            return result;
        }

        #region
        // Language 
        public static async void ChangeLanguage(UserViewModelFull userViewModelFull)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            HttpClient client = new HttpClient();


            var jsonData = JsonConvert.SerializeObject(userViewModelFull);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var Language = "";
            if (config.AppSettings.Settings["Language"] == null)
            { Language = "en"; }
            else { Language = config.AppSettings.Settings["Language"].Value; }
            var response = await client.PostAsync($"https://localhost:44331/{Language}/api/User/ChangeLanguage", content);

            var responseBody = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<AuthResultViewModel>(responseBody);

        }
        #endregion

        #region

        // Translation Language 

        public static async Task<List<Translation_LanguageViewModel>> GetLanguageTranslatedBySelectedLanguageId(int SelectedLanguageId)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var result = new List<Translation_LanguageViewModel>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44331/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var Language = "";
            if (config.AppSettings.Settings["Language"] == null)
            { Language = "en"; }
            else { Language = config.AppSettings.Settings["Language"].Value; }
            HttpResponseMessage response = client.GetAsync($"{Language}/api/Language/LanguageTranslated/" + SelectedLanguageId).Result;
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<Translation_LanguageViewModel>>(responseBody);
            }
            return result;

        }
        #endregion
    }
}
