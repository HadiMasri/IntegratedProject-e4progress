using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace E4Progress.UI.Shared
{
  public static  class HttpClientHelper<T> where T : class
  { 
        public static async Task HttpClientPostAsync(Object? model, string pathName)
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

            string Url = $"https://localhost:44331/{Language}/api/" + pathName;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            // Post the JSON and wait for a response.
            HttpResponseMessage httpResponseMessage = await client.PostAsync(Url, content);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                httpResponseMessage.StatusCode.ToString();
            }
        }

        public static async Task<List<T>> HttpClientGetAsync(string pathName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var Language = "";
            if (config.AppSettings.Settings["Language"] == null)
            {
                Language = "en";
            }
            else
            {
                Language = config.AppSettings.Settings["Language"].Value;
            }
            string Url = $"https://localhost:44331/{Language}/api/" + pathName;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(pathName).Result;
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<T>>(responseBody);
            return result;
        }

        public static async Task HttpClientDeleteAsync(int? id, string pathName)
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
            string Url = $"https://localhost:44331/{Language}/api/" + pathName + $"/" + id;
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

        public static async Task<List<T>> HttpClientGetOneByIdAsync(int? id, string pathName)
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
            string Url = $"https://localhost:44331/{Language}/api/" + pathName + $"/" + id;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // Post the JSON and wait for a response.
            HttpResponseMessage response = client.GetAsync(Url).Result;
            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<T>>(responseBody);
            return result;
        }

        public static async Task HttpClientPutAsync(Object? model, string pathName)
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

            string Url = $"https://localhost:44331/{Language}/api/" + pathName;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            // Post the JSON and wait for a response.
            HttpResponseMessage httpResponseMessage = await client.PutAsync(Url, content);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                httpResponseMessage.StatusCode.ToString();
            }
        }

        public static async Task HttpClientPatchAsync(Object? model, string pathName)
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

            string Url = $"https://localhost:44331/{Language}/api/" + pathName;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            // Post the JSON and wait for a response.
            HttpResponseMessage httpResponseMessage = await client.PatchAsync(Url, content);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                httpResponseMessage.StatusCode.ToString();
            }
        }

        //Get Translated Question Types
        public static async Task<List<T>> GetItemsTranslatedBySelectedLanguageId(string pathName ,int SelectedLanguageId)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var result = new List<T>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44331/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var Language = "";
            if (config.AppSettings.Settings["Language"] == null)
            { Language = "en"; }
            else { Language = config.AppSettings.Settings["Language"].Value; }
            HttpResponseMessage response = client.GetAsync($"{Language}/api/{pathName}/LanguageTranslated/" + SelectedLanguageId).Result;
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<T>>(responseBody);
            }
            return result;
        }
    }
}
