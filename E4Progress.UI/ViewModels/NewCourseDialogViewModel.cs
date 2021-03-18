using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
   public class NewCourseDialogViewModel:BindableBase
    {
        private string _createNewCourse = SR.ResourceManager.GetString("CreateNewCourse", Thread.CurrentThread.CurrentUICulture);
        public string CreateNewCourse
        {
            get { return _createNewCourse; }
            set { SetProperty(ref _createNewCourse, value); }
        }

        private string _courseName = SR.ResourceManager.GetString("CourseName", Thread.CurrentThread.CurrentUICulture);
        public string CourseName
        {
            get { return _courseName; }
            set { SetProperty(ref _courseName, value); }
        }
        private string _officeApplication = SR.ResourceManager.GetString("OfficeApplication", Thread.CurrentThread.CurrentUICulture);
        public string OfficeApplication
        {
            get { return _officeApplication; }
            set { SetProperty(ref _officeApplication, value); }
        }

        private string _userInterfaceLanguage = SR.ResourceManager.GetString("UserInterfaceLanguage", Thread.CurrentThread.CurrentUICulture);
        public string UserInterfaceLanguage
        {
            get { return _userInterfaceLanguage; }
            set { SetProperty(ref _userInterfaceLanguage, value); }
        }

        private string _instructionLanguage = SR.ResourceManager.GetString("InstructionLanguage", Thread.CurrentThread.CurrentUICulture);
        public string InstructionLanguage
        {
            get { return _instructionLanguage; }
            set { SetProperty(ref _instructionLanguage, value); }
        }

        private string _guid = SR.ResourceManager.GetString("GUID", Thread.CurrentThread.CurrentUICulture);
        public string GUID
        {
            get { return _guid; }
            set { SetProperty(ref _guid, value); }
        }

        private string _uploadPhoto = SR.ResourceManager.GetString("uploadPhoto", Thread.CurrentThread.CurrentUICulture);
        public string uploadPhoto
        {
            get { return _uploadPhoto; }
            set { SetProperty(ref _uploadPhoto, value); }
        }

        private string _upload = SR.ResourceManager.GetString("Upload", Thread.CurrentThread.CurrentUICulture);
        public string Upload
        {
            get { return _upload; }
            set { SetProperty(ref _upload, value); }
        }

        private string _choosePhoto = SR.ResourceManager.GetString("ChoosePhoto", Thread.CurrentThread.CurrentUICulture);
        public string ChoosePhoto
        {
            get { return _choosePhoto; }
            set { SetProperty(ref _choosePhoto, value); }
        }

        private string _cancel = SR.ResourceManager.GetString("Cancel", Thread.CurrentThread.CurrentUICulture);
        public string Cancel
        {
            get { return _cancel; }
            set { SetProperty(ref _cancel, value); }
        }

        private string _save = SR.ResourceManager.GetString("Save", Thread.CurrentThread.CurrentUICulture);
        public string Save
        {
            get { return _save; }
            set { SetProperty(ref _save, value); }
        }
    }
}
