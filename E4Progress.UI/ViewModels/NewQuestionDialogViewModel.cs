using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
    class NewQuestionDialogViewModel : BindableBase
    {
        private string _createNewQuestion = SR.ResourceManager.GetString("CreateNewQuestion", Thread.CurrentThread.CurrentUICulture);
        public string CreateNewQuestion
        {
            get { return _createNewQuestion; }
            set { SetProperty(ref _createNewQuestion, value); }
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

        private string _masterQuestion = SR.ResourceManager.GetString("MasterQuestion", Thread.CurrentThread.CurrentUICulture);
        public string MasterQuestion
        {
            get { return _masterQuestion; }
            set { SetProperty(ref _masterQuestion, value); }
        }

        private string _note = SR.ResourceManager.GetString("Note", Thread.CurrentThread.CurrentUICulture);
        public string Note
        {
            get { return _note; }
            set { SetProperty(ref _note, value); }
        }

        private string _question = SR.ResourceManager.GetString("Question", Thread.CurrentThread.CurrentUICulture);
        public string Question
        {
            get { return _question; }
            set { SetProperty(ref _question, value); }
        }

        private string _questionFormulationType = SR.ResourceManager.GetString("QuestionFormulationType", Thread.CurrentThread.CurrentUICulture);
        public string QuestionFormulationType
        {
            get { return _questionFormulationType; }
            set { SetProperty(ref _questionFormulationType, value); }
        }

        private string _questionType = SR.ResourceManager.GetString("QuestionType", Thread.CurrentThread.CurrentUICulture);
        public string QuestionType
        {
            get { return _questionType; }
            set { SetProperty(ref _questionType, value); }
        }

        private string _versionNumber = SR.ResourceManager.GetString("VersionNumber", Thread.CurrentThread.CurrentUICulture);
        public string VersionNumber
        {
            get { return _versionNumber; }
            set { SetProperty(ref _versionNumber, value); }
        }

        private string _isMasterQuestion = SR.ResourceManager.GetString("IsMasterQuestion", Thread.CurrentThread.CurrentUICulture);
        public string IsMasterQuestion
        {
            get { return _isMasterQuestion; }
            set { SetProperty(ref _isMasterQuestion, value); }
        }

        private string _cancel = SR.ResourceManager.GetString("Cancel", Thread.CurrentThread.CurrentUICulture);
        public string Cancel
        {
            get { return _cancel; }
            set { SetProperty(ref _cancel, value); }
        }
        private string _modelLevel = SR.ResourceManager.GetString("ModelLevel", Thread.CurrentThread.CurrentUICulture);
        public string ModelLevel
        {
            get { return _modelLevel; }
            set { SetProperty(ref _modelLevel, value); }
        }
        private string _sortOrder = SR.ResourceManager.GetString("SortOrder", Thread.CurrentThread.CurrentUICulture);
        public string SortOrder
        {
            get { return _sortOrder; }
            set { SetProperty(ref _sortOrder, value); }
        }
        private string _thema = SR.ResourceManager.GetString("Thema", Thread.CurrentThread.CurrentUICulture);
        public string Thema
        {
            get { return _thema; }
            set { SetProperty(ref _thema, value); }
        }
        private string _isMeasurable = SR.ResourceManager.GetString("IsMeasurable", Thread.CurrentThread.CurrentUICulture);
        public string IsMeasurable
        {
            get { return _isMeasurable; }
            set { SetProperty(ref _isMeasurable, value); }
        }
        private string _skills = SR.ResourceManager.GetString("Skills", Thread.CurrentThread.CurrentUICulture);
        public string Skills
        {
            get { return _skills; }
            set { SetProperty(ref _skills, value); }
        }
        private string _learningGoal = SR.ResourceManager.GetString("LearningGoal", Thread.CurrentThread.CurrentUICulture);
        public string LearningGoal
        {
            get { return _learningGoal; }
            set { SetProperty(ref _learningGoal, value); }
        }

        private string _save = SR.ResourceManager.GetString("Save", Thread.CurrentThread.CurrentUICulture);
        public string Save
        {
            get { return _save; }
            set { SetProperty(ref _save, value); }
        }
    }
}
