using System.Configuration;

namespace E4Progress.UI.Shared
{
  public static  class Helper
    {
        public static bool RemoveUserInfo()
        {
            bool isDeleted = false;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings.AllKeys.Length != 0)
            {
                config.AppSettings.Settings.Remove("Token");
                config.AppSettings.Settings.Remove("FirstName");
                config.AppSettings.Settings.Remove("LastName");
                config.AppSettings.Settings.Remove("Email");
                config.AppSettings.Settings.Remove("exp");
                config.AppSettings.Settings.Remove("role");
                config.AppSettings.Settings.Remove("id");
                config.AppSettings.Settings.Remove("Language"); 
                config.AppSettings.Settings.Remove("LanguageId");
                config.Save(ConfigurationSaveMode.Modified);
                isDeleted = true;
            }

            return isDeleted;
        }
    }
}
