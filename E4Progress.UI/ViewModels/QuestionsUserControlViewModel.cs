using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
   public class QuestionsUserControlViewModel : BindableBase
    {
        private string _new = SR.ResourceManager.GetString("New", Thread.CurrentThread.CurrentUICulture);
        public string New
        {
            get { return _new; }
            set { SetProperty(ref _new, value); }
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

        private string _note = SR.ResourceManager.GetString("Note", Thread.CurrentThread.CurrentUICulture);
        public string Note
        {
            get { return _note; }
            set { SetProperty(ref _note, value); }
        }

        private string _questionType = SR.ResourceManager.GetString("QuestionType", Thread.CurrentThread.CurrentUICulture);
        public string QuestionType
        {
            get { return _questionType; }
            set { SetProperty(ref _questionType, value); }
        }

        private string _delete = SR.ResourceManager.GetString("Delete", Thread.CurrentThread.CurrentUICulture);
        public string Delete
        {
            get { return _delete; }
            set { SetProperty(ref _delete, value); }
        }

        private string _title = SR.ResourceManager.GetString("Title", Thread.CurrentThread.CurrentUICulture);
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
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

        private string _idCode = SR.ResourceManager.GetString("IDCode", Thread.CurrentThread.CurrentUICulture);
        public string IDCode
        {
            get { return _idCode; }
            set { SetProperty(ref _idCode, value); }
        }

        private string _totalQuestions = SR.ResourceManager.GetString("TotalQuestions", Thread.CurrentThread.CurrentUICulture);
        public string TotalQuestions
        {
            get { return _totalQuestions; }
            set { SetProperty(ref _totalQuestions, value); }
        }

        private string _reset = SR.ResourceManager.GetString("Reset", Thread.CurrentThread.CurrentUICulture);
        public string Reset
        {
            get { return _reset; }
            set { SetProperty(ref _reset, value); }
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
