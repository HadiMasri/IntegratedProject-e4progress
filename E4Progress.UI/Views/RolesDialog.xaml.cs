using E4Progress.Shared.ViewModels;
using E4Progress.UI.services;
using E4Progress.UI.ViewModels;
using E4Progress.UI.ViewModelsdata;
using System.Collections.Generic;
using System.Windows;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for RolesDialog.xaml
    /// </summary>
    public partial class RolesDialog : Window
    {
        private UserViewModel userViewModel;
       
        public RolesDialog(UserViewModel _userViewModel)
        {
            this.userViewModel = _userViewModel;
            InitializeComponent();
            cmbRoles.ItemsSource = services.service.GetRole().Result;
            txtUser.Text = userViewModel.Name;
            GetUserRoleByUserId(userViewModel.Id);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void GetUserRoleByUserId(int userId)
        {
            lstActiveRole.Items.Clear();
            var userRoles = services.service.GetUserRoleByUserId(userId).Result;
            foreach (var item in userRoles)
            {
                lstActiveRole.Items.Add(new RoleViewModel
                {
                  Id  = item.role.Id,
                   Name = item.role.Name
                });
            }

        }

        private async void btnasign_Click(object sender, RoutedEventArgs e)
        {
            RolesDialogViewModel roleDialogViewModel = new RolesDialogViewModel();
            bool roleExist = false;
            var userRoles = services.service.GetUserRoleByUserId(userViewModel.Id).Result;
            var model = new UserRoleViewModel
            {
                UserId = userViewModel.Id,
                RoleId = (int)cmbRoles.SelectedValue
            };

            foreach (var item in userRoles)
            {
                if (item.role.Id == model.RoleId)
                {
                    roleExist = true;
                }
            }
            if (model != null)
            {
                if (roleExist)
                {
                    txtMessage.Text = roleDialogViewModel.AssignUserErrorMessage ;
                }
                else
                {
                    await services.service.AsigneRoleToUser(model);
                    txtMessage.Text = roleDialogViewModel.AssignNewRoleMessage;
                    GetUserRoleByUserId(userViewModel.Id);
                }
            }
        }

        private async void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            RolesDialogViewModel roleDialogViewModel = new RolesDialogViewModel();

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(roleDialogViewModel.ConfirmationMessage, roleDialogViewModel.DeleteConfirmation, MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {

                try
                {
                    RoleViewModel datagridRaw = (RoleViewModel)lstActiveRole.SelectedItem;
                    await service.EndRoleAsync(datagridRaw.Id, userViewModel.Id, "endRole");
                    GetUserRoleByUserId(userViewModel.Id);
                }
                catch (System.Exception ex)
                {

                    throw new System.Exception(ex.Message);
                }

            }
        }
    }
}
