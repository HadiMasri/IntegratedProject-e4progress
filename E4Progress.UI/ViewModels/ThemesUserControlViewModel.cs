using Prism.Mvvm;

namespace E4Progress.UI.ViewModels
{
    public class ThemesUserControlViewModel : BindableBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }
    }
}

