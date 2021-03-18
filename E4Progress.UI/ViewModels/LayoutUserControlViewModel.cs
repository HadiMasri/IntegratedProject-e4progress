using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
   public class LayoutUserControlViewModel : BindableBase
    {
        private string _course = SR.ResourceManager.GetString("Course", Thread.CurrentThread.CurrentUICulture);
        public string Course
        {
            get { return _course; }
            set { SetProperty(ref _course, value); }
        }

        private string _title = SR.ResourceManager.GetString("Title", Thread.CurrentThread.CurrentUICulture);
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _edit = SR.ResourceManager.GetString("Edit", Thread.CurrentThread.CurrentUICulture);
        public string Edit
        {
            get { return _edit; }
            set { SetProperty(ref _edit, value); }
        }

        private string _delete = SR.ResourceManager.GetString("Delete", Thread.CurrentThread.CurrentUICulture);
        public string Delete
        {
            get { return _delete; }
            set { SetProperty(ref _delete, value); }
        }

        private string _module = SR.ResourceManager.GetString("Module", Thread.CurrentThread.CurrentUICulture);
        public string Module
        {
            get { return _module; }
            set { SetProperty(ref _module, value); }
        }

        private string _topic = SR.ResourceManager.GetString("Topic", Thread.CurrentThread.CurrentUICulture);
        public string Topic
        {
            get { return _topic; }
            set { SetProperty(ref _topic, value); }
        }

        private string _element = SR.ResourceManager.GetString("Element", Thread.CurrentThread.CurrentUICulture);
        public string Element
        {
            get { return _element; }
            set { SetProperty(ref _element, value); }
        }

        private string _save = SR.ResourceManager.GetString("Save", Thread.CurrentThread.CurrentUICulture);
        public string Save
        {
            get { return _save; }
            set { SetProperty(ref _save, value); }
        }

        private string _cancel = SR.ResourceManager.GetString("Cancel", Thread.CurrentThread.CurrentUICulture);
        public string Cancel
        {
            get { return _cancel; }
            set { SetProperty(ref _cancel, value); }
        }

        private string _update = SR.ResourceManager.GetString("Update", Thread.CurrentThread.CurrentUICulture);
        public string Update
        {
            get { return _update; }
            set { SetProperty(ref _update, value); }
        }

        private string _new = SR.ResourceManager.GetString("New", Thread.CurrentThread.CurrentUICulture);
        public string New
        {
            get { return _new; }
            set { SetProperty(ref _new, value); }
        }
    }
}
