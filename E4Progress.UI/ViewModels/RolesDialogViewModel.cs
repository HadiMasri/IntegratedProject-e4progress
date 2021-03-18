using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
    public class RolesDialogViewModel : BindableBase
    {
        private string _assign = SR.ResourceManager.GetString("Assign", Thread.CurrentThread.CurrentUICulture);
        public string Assign
        {
            get { return _assign; }
            set { SetProperty(ref _assign, value); }
        }

        private string _close= SR.ResourceManager.GetString("Close", Thread.CurrentThread.CurrentUICulture);
        public string Close
        {
            get { return _close; }
            set { SetProperty(ref _close, value); }
        }

        private string _role = SR.ResourceManager.GetString("Role", Thread.CurrentThread.CurrentUICulture);
        public string Role
        {
            get { return _role; }
            set { SetProperty(ref _role, value); }
        }

        private string _activeRoles = SR.ResourceManager.GetString("ActiveRoles", Thread.CurrentThread.CurrentUICulture);
        public string ActiveRoles
        {
            get { return _activeRoles; }
            set { SetProperty(ref _activeRoles, value); }
        }

        private string _assignUserSuccessMessage = SR.ResourceManager.GetString("AssignUserSuccessMessage", Thread.CurrentThread.CurrentUICulture);
        public string AssignUserSuccessMessage
        {
            get { return _assignUserSuccessMessage; }
            set { SetProperty(ref _assignUserSuccessMessage, value); }
        }

        private string _assignUserErrorMessage = SR.ResourceManager.GetString("AssignUserErrorMessage", Thread.CurrentThread.CurrentUICulture);
        public string AssignUserErrorMessage
        {
            get { return _assignUserErrorMessage; }
            set { SetProperty(ref _assignUserErrorMessage, value); }
        }

        private string _assignNewRoleMessage = SR.ResourceManager.GetString("AssignNewRoleMessage", Thread.CurrentThread.CurrentUICulture);
        public string AssignNewRoleMessage
        {
            get { return _assignNewRoleMessage; }
            set { SetProperty(ref _assignNewRoleMessage, value); }
        }

        private string _deleteConfirmation = SR.ResourceManager.GetString("DeleteConfirmation", Thread.CurrentThread.CurrentUICulture);
        public string DeleteConfirmation
        {
            get { return _deleteConfirmation; }
            set { SetProperty(ref _deleteConfirmation, value); }
        }

        private string _confirmationMessage = SR.ResourceManager.GetString("ConfirmationMessage", Thread.CurrentThread.CurrentUICulture);
        public string ConfirmationMessage
        {
            get { return _confirmationMessage; }
            set { SetProperty(ref _confirmationMessage, value); }
        }
    }
}
