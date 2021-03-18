using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
    class QuestionUserControlViewModel : BindableBase
    {
        private string _title = SR.ResourceManager.GetString("Title", Thread.CurrentThread.CurrentUICulture);
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _questionType = SR.ResourceManager.GetString("QuestionType", Thread.CurrentThread.CurrentUICulture);
        public string QuestionType
        {
            get { return _questionType; }
            set { SetProperty(ref _questionType, value); }
        }

        private string _note = SR.ResourceManager.GetString("Note", Thread.CurrentThread.CurrentUICulture);
        public string Note
        {
            get { return _note; }
            set { SetProperty(ref _note, value); }
        }

        private string _questionTypeName = SR.ResourceManager.GetString("QuestionTypeName", Thread.CurrentThread.CurrentUICulture);
        public string QuestionTypeName
        {
            get { return _questionTypeName; }
            set { SetProperty(ref _questionTypeName, value); }
        }

        private string _officeApplication = SR.ResourceManager.GetString("OfficeApplication", Thread.CurrentThread.CurrentUICulture);
        public string OfficeApplication
        {
            get { return _officeApplication; }
            set { SetProperty(ref _officeApplication, value); }
        }

        private string _instructionLanguage = SR.ResourceManager.GetString("InstructionLanguage", Thread.CurrentThread.CurrentUICulture);
        public string InstructionLanguage
        {
            get { return _instructionLanguage; }
            set { SetProperty(ref _instructionLanguage, value); }
        }

        private string _title_header = SR.ResourceManager.GetString("Title_header", Thread.CurrentThread.CurrentUICulture);
        public string Title_header
        {
            get { return _title_header; }
            set { SetProperty(ref _title_header, value); }
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

        private string _details = SR.ResourceManager.GetString("Details", Thread.CurrentThread.CurrentUICulture);
        public string Details
        {
            get { return _details; }
            set { SetProperty(ref _details, value); }
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
