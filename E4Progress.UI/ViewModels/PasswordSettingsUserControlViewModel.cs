using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
  public  class PasswordSettingsUserControlViewModel: BindableBase
    {
        private string _newPassword = SR.ResourceManager.GetString("NewPassword", Thread.CurrentThread.CurrentUICulture);
        public string NewPassword
        {
            get { return _newPassword; }
            set { SetProperty(ref _newPassword, value); }
        }

        private string _save = SR.ResourceManager.GetString("Save", Thread.CurrentThread.CurrentUICulture);
        public string Save
        {
            get { return _save; }
            set { SetProperty(ref _save, value); }
        }

        private string _setPassword = SR.ResourceManager.GetString("SetPassword", Thread.CurrentThread.CurrentUICulture);
        public string SetPassword
        {
            get { return _setPassword; }
            set { SetProperty(ref _setPassword, value); }
        }

        private string _confirmPassword = SR.ResourceManager.GetString("ConfirmPassword", Thread.CurrentThread.CurrentUICulture);
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { SetProperty(ref _confirmPassword, value); }
        }

        private string _password = SR.ResourceManager.GetString("Password", Thread.CurrentThread.CurrentUICulture);
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
    }
}
