using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;
using E4Progress.UI.ViewModelsdata;
using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string language = config.AppSettings.Settings["Language"].Value;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            InitializeComponent();
           
            FillMenuItems();
            StackPanelMain.Children.Add(new CoursesUserControl());
            txtUserName.Text = "";
        }

        // Menus en submenus vullen
        public void FillMenuItems()
        {
           
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            var contentMenu = new List<SubMenuItem>
            {
                new SubMenuItem(mainWindowViewModel.Courses, new CoursesUserControl()),
                new SubMenuItem(mainWindowViewModel.Quizzes, new QuizzesUserControl()),
                new SubMenuItem(mainWindowViewModel.Questions, new QuestionsUserControl()),
                new SubMenuItem(mainWindowViewModel.Subject, new ThemesUserControl()),
                new SubMenuItem(mainWindowViewModel.Uitrol, new RolloutUserControl())
            };
            var item0 = new ItemMenu(mainWindowViewModel.Content, contentMenu, PackIconKind.ContentCopy);

      
            var securityMenu = new List<SubMenuItem>
            {
                new SubMenuItem(mainWindowViewModel.Users, new UsersUserControl()),
                new SubMenuItem(mainWindowViewModel.Roles, new RolesUserControl())
            };
            var item1 = new ItemMenu(mainWindowViewModel.Security, securityMenu, PackIconKind.Security);


            var profileMenu = new List<SubMenuItem>
            {
                new SubMenuItem(mainWindowViewModel.SetPassword, new PasswordSettingsUserControl())
            };
            var item2 = new ItemMenu(mainWindowViewModel.Profile, profileMenu, PackIconKind.Person);


            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            Menu.Children.Add(new MenuItemsUserControl(item0, this));
            if (config.AppSettings.Settings["role"].Value == "Admin")
            {
                Menu.Children.Add(new MenuItemsUserControl(item1, this));
            }
        
            Menu.Children.Add(new MenuItemsUserControl(item2, this));
        }

        /// <summary>
        /// Change screen based on the selected menu item
        /// </summary>
        /// <param name="sender"></param>
        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                MainPanel.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }


        // UI EventArgs
        #region

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                StackPanelMain.Visibility = Visibility.Collapsed;
            }
            else
            {
                StackPanelMain.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            StackPanelMain.Opacity = 1;
            txtUserName.Visibility = Visibility.Hidden;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            StackPanelMain.Opacity = 1;
            txtUserName.Visibility = Visibility.Visible;
        }

        private void MainPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
            nav_pnl.Opacity = 1;
        }

        private void btnShutdown_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //private void btnMaximize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    WindowState = WindowState.Maximized;
        //}

        private void headerBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        #endregion

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings.AllKeys != null)
            {
                var FirstName = config.AppSettings.Settings["FirstName"].Value;
                var LastName = config.AppSettings.Settings["LastName"].Value;

                txtUserName.Text = $"{ FirstName} {LastName}";
            }

        }

 

        //private void btnLogOut_Click(object sender, RoutedEventArgs e)
        //{
        //    Helper.RemoveUserInfo();

        //    //Disable shutdown when the dialog closes
        //    txtUserName.Text = "";
        //    Close();
        //    Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

        //    var dialog = new LoginDialog();
        //    dialog.Show();
        //}

        private void StackPanelMain_GotFocus(object sender, RoutedEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void PackIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Helper.RemoveUserInfo();

            //Disable shutdown when the dialog closes
            txtUserName.Text = "";
            Close();
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            var dialog = new LoginDialog();
            dialog.Show();
        }
    }
}
