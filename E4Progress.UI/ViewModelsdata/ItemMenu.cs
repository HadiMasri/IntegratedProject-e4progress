using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Windows.Controls;

namespace E4Progress.UI.ViewModelsdata
{
    public class ItemMenu
    {
        public ItemMenu(string header, List<SubMenuItem> subItems, PackIconKind icon)
        {
            Header = header;
            SubItems = subItems;
            Icon = icon;
        }

        public ItemMenu(string header, UserControl screen, PackIconKind icon)
        {
            Header = header;
            Screen = screen;
            Icon = icon;
        }

        public string Header { get; private set; }

        public PackIconKind Icon { get; private set; }

        public List<SubMenuItem> SubItems { get; private set; }

        public UserControl Screen { get; private set; }
    }
}
