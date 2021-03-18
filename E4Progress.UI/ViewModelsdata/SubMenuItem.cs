using System.Windows.Controls;

namespace E4Progress.UI.ViewModelsdata
{
    public class SubMenuItem
    {
        public SubMenuItem(string name, UserControl screen = null)
        {
            Name = name;
            Screen = screen;
        }

        public string Name { get; set; }
        public UserControl Screen { get; set; }
    }
}
