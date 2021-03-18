using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
    public class RolesUserControlViewModel : BindableBase
    {

        private string _user = SR.ResourceManager.GetString("User", Thread.CurrentThread.CurrentUICulture);
        public string User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }

        private string _role = SR.ResourceManager.GetString("Role", Thread.CurrentThread.CurrentUICulture);
        public string Role
        {
            get { return _role; }
            set { SetProperty(ref _role, value); }
        }

        private string _assign = SR.ResourceManager.GetString("Assign", Thread.CurrentThread.CurrentUICulture);
        public string Assign
        {
            get { return _assign; }
            set { SetProperty(ref _assign, value); }
        }

        private string _owneUser = SR.ResourceManager.GetString("OwneUser", Thread.CurrentThread.CurrentUICulture);
        public string OwneUser
        {
            get { return _owneUser; }
            set { SetProperty(ref _owneUser, value); }
        }

        private string _checkMessage = SR.ResourceManager.GetString("CheckMessage", Thread.CurrentThread.CurrentUICulture);
        public string CheckMessage
        {
            get { return _checkMessage; }
            set { SetProperty(ref _checkMessage, value); }
        }

        private string _ancleDelete = SR.ResourceManager.GetString("CancleDelete", Thread.CurrentThread.CurrentUICulture);
        public string CancleDelete
        {
            get { return _ancleDelete; }
            set { SetProperty(ref _ancleDelete, value); }
        }

        private string _deleteConfirmation = SR.ResourceManager.GetString("DeleteConfirmation", Thread.CurrentThread.CurrentUICulture);
        public string DeleteConfirmation
        {
            get { return _deleteConfirmation; }
            set { SetProperty(ref _deleteConfirmation, value); }
         
        }
        private string _refresh = SR.ResourceManager.GetString("Refresh", Thread.CurrentThread.CurrentUICulture);
        public string Refresh
        {
            get { return _refresh; }
            set { SetProperty(ref _refresh, value); }
             
        }
        private string _pleasSelectUserFromTheList = SR.ResourceManager.GetString("PleasSelectUserFromTheList", Thread.CurrentThread.CurrentUICulture);
        public string PleasSelectUserFromTheList
        {
            get { return _pleasSelectUserFromTheList; }
            set { SetProperty(ref _pleasSelectUserFromTheList, value); }
            
        }
    }
}
