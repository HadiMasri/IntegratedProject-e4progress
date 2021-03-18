﻿using E4Progress.UI.Strings;
using Prism.Mvvm;
using System.Threading;

namespace E4Progress.UI.ViewModels
{
    public class NewQuizDialogViewModel : BindableBase
    {
        private string _createNewQuiz = SR.ResourceManager.GetString("CreateNewQuiz", Thread.CurrentThread.CurrentUICulture);
        public string CreateNewQuiz
        {
            get { return _createNewQuiz; }
            set { SetProperty(ref _createNewQuiz, value); }
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

        private string _guid = SR.ResourceManager.GetString("GUID", Thread.CurrentThread.CurrentUICulture);
        public string GUID
        {
            get { return _guid; }
            set { SetProperty(ref _guid, value); }
        }

        private string _shortIntro = SR.ResourceManager.GetString("ShortIntro", Thread.CurrentThread.CurrentUICulture);
        public string ShortIntro
        {
            get { return _shortIntro; }
            set { SetProperty(ref _shortIntro, value); }
        }

        private string _intro = SR.ResourceManager.GetString("Intro", Thread.CurrentThread.CurrentUICulture);
        public string Intro
        {
            get { return _intro; }
            set { SetProperty(ref _intro, value); }
        }

        private string _minScore = SR.ResourceManager.GetString("MinScore", Thread.CurrentThread.CurrentUICulture);
        public string MinScore
        {
            get { return _minScore; }
            set { SetProperty(ref _minScore, value); }
        }

        private string _idCode = SR.ResourceManager.GetString("IDCode", Thread.CurrentThread.CurrentUICulture);
        public string IDCode
        {
            get { return _idCode; }
            set { SetProperty(ref _idCode, value); }
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

        private string _quizCreated = SR.ResourceManager.GetString("QuizCreated", Thread.CurrentThread.CurrentUICulture);
        public string QuizCreated
        {
            get { return _quizCreated; }
            set { SetProperty(ref _quizCreated, value); }
        }

        private string _validationError = SR.ResourceManager.GetString("ValidationError", Thread.CurrentThread.CurrentUICulture);
        public string ValidationError
        {
            get { return _validationError; }
            set { SetProperty(ref _validationError, value); }
        }
    }
}