using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {}

        private string _courses = SR.ResourceManager.GetString("Courses", Thread.CurrentThread.CurrentUICulture);
        public string Courses
        {
            get { return _courses; }
            set { SetProperty(ref _courses, value); }
        }

        private string _uitrol = SR.ResourceManager.GetString("Uitrol", Thread.CurrentThread.CurrentUICulture);
        public string Uitrol
        {
            get { return _uitrol; }
            set { SetProperty(ref _uitrol, value); }
        }

        private string _content = SR.ResourceManager.GetString("Content", Thread.CurrentThread.CurrentUICulture);
        public string Content
        {
            get { return _content; }
            set { SetProperty(ref _content, value); }
        }

        private string _exerciseFiles = SR.ResourceManager.GetString("ExerciseFiles", Thread.CurrentThread.CurrentUICulture);
        public string Exercisefiles
        {
            get { return _exerciseFiles; }
            set { SetProperty(ref _exerciseFiles, value); }
        }

        private string _profile = SR.ResourceManager.GetString("Profile", Thread.CurrentThread.CurrentUICulture);
        public string Profile
        {
            get { return _profile; }
            set { SetProperty(ref _profile, value); }
        }

        private string _questions = SR.ResourceManager.GetString("Questions", Thread.CurrentThread.CurrentUICulture);
        public string Questions
        {
            get { return _questions; }
            set { SetProperty(ref _questions, value); }
        }

        private string _quizzes = SR.ResourceManager.GetString("Quizzes", Thread.CurrentThread.CurrentUICulture);
        public string Quizzes
        {
            get { return _quizzes; }
            set { SetProperty(ref _quizzes, value); }
        }

        private string _roles = SR.ResourceManager.GetString("Roles", Thread.CurrentThread.CurrentUICulture);
        public string Roles
        {
            get { return _roles; }
            set { SetProperty(ref _roles, value); }
        }

        private string _security = SR.ResourceManager.GetString("Security", Thread.CurrentThread.CurrentUICulture);
        public string Security
        {
            get { return _security; }
            set { SetProperty(ref _security, value); }
        }

        private string _setPassword = SR.ResourceManager.GetString("SetPassword", Thread.CurrentThread.CurrentUICulture);
        public string SetPassword
        {
            get { return _setPassword; }
            set { SetProperty(ref _setPassword, value); }
        }

        private string _subject = SR.ResourceManager.GetString("Subject", Thread.CurrentThread.CurrentUICulture);
        public string Subject
        {
            get { return _subject; }
            set { SetProperty(ref _subject, value); }
        }

        private string _users = SR.ResourceManager.GetString("Users", Thread.CurrentThread.CurrentUICulture);
        public string Users
        {
            get { return _users; }
            set { SetProperty(ref _users, value); }
        }

        private string _logout= SR.ResourceManager.GetString("Logout", Thread.CurrentThread.CurrentUICulture);
        public string Logout
        {
            get { return _logout; }
            set { SetProperty(ref _logout, value); }
        }
    }
}
