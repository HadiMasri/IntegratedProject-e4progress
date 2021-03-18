using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;
using System.Windows.Input;

namespace E4Progress.UI.ViewModels
{
   public class Content_ThemeViewModel : BindableBase
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

