using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
    class QuizQuestionDialogViewModel : BindableBase
    {
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

        private string _search = SR.ResourceManager.GetString("Search", Thread.CurrentThread.CurrentUICulture);
        public string Search
        {
            get { return _search; }
            set { SetProperty(ref _search, value); }
        }

        private string _questions = SR.ResourceManager.GetString("Questions", Thread.CurrentThread.CurrentUICulture);
        public string Questions
        {
            get { return _questions; }
            set { SetProperty(ref _questions, value); }
        }

        private string _quizUpdated = SR.ResourceManager.GetString("QuizUpdated", Thread.CurrentThread.CurrentUICulture);
        public string QuizUpdated
        {
            get { return _quizUpdated; }
            set { SetProperty(ref _quizUpdated, value); }
        }
    }
}