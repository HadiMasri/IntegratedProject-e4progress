using E4Progress.UI.ViewModelsdata;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for MenuItemsUserControl.xaml
    /// </summary>
    public partial class MenuItemsUserControl : UserControl
    {
        MainWindow _context;
        public MenuItemsUserControl(ItemMenu itemMenu, MainWindow context)
        {
            InitializeComponent();

            _context = context;

            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

            this.DataContext = itemMenu;
        }

        private void lbSubItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _context.SwitchScreen(((TextBlock)sender).Tag);
        }

        private void OpenPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_context.Tg_Btn.IsChecked == false)
            {
                _context.Tg_Btn.IsChecked = true;
            }
        }
    }
}
