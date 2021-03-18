using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
   public class CoursesUserControlViewModel : BindableBase
    {
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

        private string _courseName_header = SR.ResourceManager.GetString("CourseName_header", Thread.CurrentThread.CurrentUICulture);
        public string CourseName_header
        {
            get { return _courseName_header; }
            set { SetProperty(ref _courseName_header, value); }
        }

        private string _officeApplication_header = SR.ResourceManager.GetString("OfficeApplication_header", Thread.CurrentThread.CurrentUICulture);
        public string OfficeApplication_header
        {
            get { return _officeApplication_header; }
            set { SetProperty(ref _officeApplication_header, value); }
        }

        private string _userInterfaceLanguage_header = SR.ResourceManager.GetString("UserInterfaceLanguage_header", Thread.CurrentThread.CurrentUICulture);
        public string UserInterfaceLanguage_header
        {
            get { return _userInterfaceLanguage_header; }
            set { SetProperty(ref _userInterfaceLanguage_header, value); }
        }


        private string _instructionLanguage_header = SR.ResourceManager.GetString("InstructionLanguage_header", Thread.CurrentThread.CurrentUICulture);
        public string InstructionLanguage_header
        {
            get { return _instructionLanguage_header; }
            set { SetProperty(ref _instructionLanguage_header, value); }
        }

        private string _numberOfModules = SR.ResourceManager.GetString("NumberOfModules", Thread.CurrentThread.CurrentUICulture);
        public string NumberOfModules
        {
            get { return _numberOfModules; }
            set { SetProperty(ref _numberOfModules, value); }
        }

        private string _numberOfTopics = SR.ResourceManager.GetString("NumberOfTopics", Thread.CurrentThread.CurrentUICulture);
        public string NumberOfTopics
        {
            get { return _numberOfTopics; }
            set { SetProperty(ref _numberOfTopics, value); }
        }

        private string _new = SR.ResourceManager.GetString("New", Thread.CurrentThread.CurrentUICulture);
        public string New
        {
            get { return _new; }
            set { SetProperty(ref _new, value); }
        }

        private string _reset = SR.ResourceManager.GetString("Reset", Thread.CurrentThread.CurrentUICulture);
        public string Reset
        {
            get { return _reset; }
            set { SetProperty(ref _reset, value); }
        }

        private string _update = SR.ResourceManager.GetString("Update", Thread.CurrentThread.CurrentUICulture);
        public string Update
        {
            get { return _update; }
            set { SetProperty(ref _update, value); }
        }

        private string _details = SR.ResourceManager.GetString("Details", Thread.CurrentThread.CurrentUICulture);
        public string Details
        {
            get { return _details; }
            set { SetProperty(ref _details, value); }
        }

        private string _rowsPerPage = SR.ResourceManager.GetString("RowsPerPage", Thread.CurrentThread.CurrentUICulture);
        public string RowsPerPage
        {
            get { return _rowsPerPage; }
            set { SetProperty(ref _rowsPerPage, value); }
        }

        private string _layout = SR.ResourceManager.GetString("Layout", Thread.CurrentThread.CurrentUICulture);
        public string Layout
        {
            get { return _layout; }
            set { SetProperty(ref _layout, value); }
        }

        private string _english = SR.ResourceManager.GetString("English", Thread.CurrentThread.CurrentUICulture);
        public string English
        {
            get { return _english; }
            set { SetProperty(ref _english, value); }
        }

        private string _dutch = SR.ResourceManager.GetString("Dutch", Thread.CurrentThread.CurrentUICulture);
        public string Dutch
        {
            get { return _dutch; }
            set { SetProperty(ref _dutch, value); }
        }

        private string _french = SR.ResourceManager.GetString("French", Thread.CurrentThread.CurrentUICulture);
        public string French
        {
            get { return _french; }
            set { SetProperty(ref _french, value); }
        }
    }
}
