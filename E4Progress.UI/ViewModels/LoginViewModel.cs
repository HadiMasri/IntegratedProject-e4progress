using E4Progress.UI.Strings;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
    public class LoginViewModel : BindableBase
    {
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
    }
}
