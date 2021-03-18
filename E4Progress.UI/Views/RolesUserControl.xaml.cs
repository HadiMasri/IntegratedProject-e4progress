using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;
using E4Progress.UI.ViewModelsdata;
using Prism.Services.Dialogs;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for RolesUserControl.xaml
    /// </summary>
    public partial class RolesUserControl : UserControl
    {
        RolesUserControlViewModel rolesUserControlViewModel = new RolesUserControlViewModel();
        List<UserViewModel> users = new List<UserViewModel>();
        UserViewModel slectedUser = new UserViewModel();
      
        public RolesUserControl()
        {
            InitializeComponent();

            //cmbUser.ItemsSource = GetAllUsers().Result;
             
            fillUserIntoList();
        }
        private void fillUserIntoList()
        {
            var ListOfusers = GetAllUsers();
            foreach (var user in ListOfusers)
            {
                if (ListOfusers.Count > 0) RoleListView.ItemsSource = users;
            }
        }

        private  List<UserViewModel> GetAllUsers()
        {
            users =  services.service.GetUser().Result;
            return users;
        }

        /// <summary>
        /// Enables scroll functionality on the content of the scrollviewer
        /// Scrolling can be done with the mouse wheel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SVUserList_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void RoleListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            slectedUser = null;
            if (RoleListView.SelectedIndex != -1)
            {
                ListBoxItem lbi = (RoleListView.ItemContainerGenerator.ContainerFromIndex(RoleListView.SelectedIndex)) as ListBoxItem;
                slectedUser = (UserViewModel)lbi.Content;
            }
       
        }

        /// <summary>
        /// Call the roledialog to edit the role of selected user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditUser_Click(object sender, RoutedEventArgs e)
        {
            if (slectedUser != null)
            {
                if (slectedUser.Id != 0)
                {
                    RolesDialog dialog = new RolesDialog(slectedUser);
                    dialog.ShowDialog();
                }
                else
                {
                    System.Windows.MessageBox.Show(rolesUserControlViewModel.PleasSelectUserFromTheList);
                }
            }
           
        }

        /// <summary>
        /// Deletes the selected user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            RolesUserControlViewModel rolesUserControlViewModel = new RolesUserControlViewModel();
            if (slectedUser != null)
            {

            
            if (slectedUser.Id != 0)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(rolesUserControlViewModel.CheckMessage, rolesUserControlViewModel.DeleteConfirmation, System.Windows.MessageBoxButton.YesNo);
                var LoggedInUserId = int.Parse(config.AppSettings.Settings["id"].Value);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    if (LoggedInUserId == slectedUser.Id)
                    {
                        MessageBoxResult messageBoxResult2 = System.Windows.MessageBox.Show(rolesUserControlViewModel.OwneUser, rolesUserControlViewModel.DeleteConfirmation, System.Windows.MessageBoxButton.YesNo);
                        if (messageBoxResult == MessageBoxResult.Yes)
                        {
                            await HttpClientHelper<UserViewModel>.HttpClientDeleteAsync(slectedUser.Id, "User");
                            Helper.RemoveUserInfo();

                            //Disable shutdown when the dialog closes

                            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

                            var dialog = new LoginDialog();
                            dialog.Show();
                        }
                        else
                        {
                            System.Windows.MessageBox.Show(rolesUserControlViewModel.CancleDelete);
                        }
                    }
                    else
                    {
                        await HttpClientHelper<UserViewModel>.HttpClientDeleteAsync(slectedUser.Id, "User");
                        fillUserIntoList();
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show(rolesUserControlViewModel.CancleDelete);
                }
            } else
            {
                System.Windows.MessageBox.Show(rolesUserControlViewModel.PleasSelectUserFromTheList);
            }
            }
        }

        private void TxtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtFilter.Text != null)
            {
                var filteredUser = users.Where(u => u.Name.ToLower().Contains(TxtFilter.Text.ToLower()));
                RoleListView.ItemsSource = filteredUser;
            }
        }
        /// <summary>
        /// Letter validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lettersValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            fillUserIntoList();
        }
    }
}
