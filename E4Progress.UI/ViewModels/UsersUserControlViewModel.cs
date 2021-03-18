using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
  public  class UsersUserControlViewModel : BindableBase
    {
        public UsersUserControlViewModel()
        {}

        private string _newUser = SR.ResourceManager.GetString("NewUser", Thread.CurrentThread.CurrentUICulture);
        public string NewUser
        {
            get { return _newUser; }
            set { SetProperty(ref _newUser, value); }
        }

        private string _firstName = SR.ResourceManager.GetString("FirstName", Thread.CurrentThread.CurrentUICulture);
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName = SR.ResourceManager.GetString("LastName", Thread.CurrentThread.CurrentUICulture);
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        private string _email = SR.ResourceManager.GetString("Email", Thread.CurrentThread.CurrentUICulture);
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _password = SR.ResourceManager.GetString("Password", Thread.CurrentThread.CurrentUICulture);
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private string _confirmPassword = SR.ResourceManager.GetString("ConfirmPassword", Thread.CurrentThread.CurrentUICulture);
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { SetProperty(ref _confirmPassword, value); }
        }

        private string _role = SR.ResourceManager.GetString("Role", Thread.CurrentThread.CurrentUICulture);
        public string Role
        {
            get { return _role; }
            set { SetProperty(ref _role, value); }
        }

        private string _registerMessagePasswordNotMatch = SR.ResourceManager.GetString("RegisterMessagePasswordNotMatch", Thread.CurrentThread.CurrentUICulture);
        public string RegisterMessagePasswordNotMatch
        {
            get { return _registerMessagePasswordNotMatch; }
            set { SetProperty(ref _registerMessagePasswordNotMatch, value); }
        }

        private string _RegisterSuccessMesssage = SR.ResourceManager.GetString("RegisterSuccessMesssage", Thread.CurrentThread.CurrentUICulture);

        public string RegisterSuccessMesssage
        {
            get { return _RegisterSuccessMesssage; }
            set { SetProperty(ref _RegisterSuccessMesssage, value); }
        }

        private string _registerDuplicateEmailMesssage = SR.ResourceManager.GetString("RegisterDuplicateEmailMesssage", Thread.CurrentThread.CurrentUICulture);

        public string RegisterDuplicateEmailMesssage
        {
            get { return _registerDuplicateEmailMesssage; }
            set { SetProperty(ref _registerDuplicateEmailMesssage, value); }
        }

        private string _save = SR.ResourceManager.GetString("Save", Thread.CurrentThread.CurrentUICulture);
        public string Save
        {
            get { return _save; }
            set { SetProperty(ref _save, value); }
           
        }
        private string _inValidEmail = SR.ResourceManager.GetString("InValidEmail", Thread.CurrentThread.CurrentUICulture);
        public string InValidEmail
        {
            get { return _inValidEmail; }
            set { SetProperty(ref _inValidEmail, value); }
           
        }
    }
}
