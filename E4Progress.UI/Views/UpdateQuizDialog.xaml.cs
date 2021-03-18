using E4Progress.DAL.Entities;
using E4Progress.Shared.ViewModels;
using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using System.Windows;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for UpdateQuizDialog.xaml
    /// </summary>
    public partial class UpdateQuizDialog : Window
    {
        readonly Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        readonly UpdateQuizDialogViewModel model = new UpdateQuizDialogViewModel();
        readonly QuizzesUserControl _quizzesUserControl;

        Quiz quiz;
        List<Quiz_Question> QuizQuestions;

        List<Office_Application> Apps;
        List<Translation_LanguageViewModel> Languages;

        public UpdateQuizDialog(Quiz getQuiz, QuizzesUserControl quizzesUserControl)
        {
            InitializeComponent();

            quiz = getQuiz;
            _quizzesUserControl = quizzesUserControl;
        }

        /// <summary>
        /// Load data for languages and quizQuestions.
        /// Fill comboboxes with said data.
        /// Display information about quiz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Apps = await HttpClientHelper<Office_Application>.HttpClientGetAsync("OfficeApplication");
            QuizQuestions = await HttpClientHelper<Quiz_Question>.HttpClientGetAsync("quizquestion");
            Languages = services.service.GetLanguageTranslatedBySelectedLanguageId(Convert.ToInt32(config.AppSettings.Settings["languageId"].Value)).Result;

            PickerOffice.ItemsSource = Apps;
            PickerInstructionLanguage.ItemsSource = Languages;
            PickerUILanguage.ItemsSource = Languages;

            AssignInformation();
        }

        /// <summary>
        /// Fetch data from the Quiz to be updated.
        /// Fill all (readonly) input fields with corresponding data.
        /// </summary>
        private void AssignInformation()
        {
            TextTitle.Text = quiz.Title;
            PickerOffice.SelectedIndex = quiz.Office_Application_Id - 1;
            PickerInstructionLanguage.SelectedIndex = quiz.Instruction_Language_Id - 2;
            PickerUILanguage.SelectedIndex = quiz.Userinterface_Language_Id - 2;
            TextIdentificationCode.Text = quiz.Identification_Code;
            TextMinScore.Text = quiz.Default_Minimum_Score + "";
            TextHours.Text = Math.Truncate(quiz.Default_Time_Limit.TotalHours) + "";
            TextMinutes.Text = quiz.Default_Time_Limit.Minutes + "";
            TextSeconds.Text = quiz.Default_Time_Limit.Seconds + "";
            TextShortIntro.Text = quiz.Short_Intro;
            TextIntro.Text = quiz.Intro;
            TextCreationDate.Text = quiz.Creation_Timestamp.ToShortDateString();
            TextReplicationKey.Text = quiz.ReplicationKey.ToString();

            TextNumberOfQuestions.Text = model.Questions + ": " + QuizQuestions.FindAll(qq => qq.Quiz_Id == quiz.Id).Count;
        }

        /// <summary>
        /// Validate all input fields on business rules.
        /// </summary>
        /// <returns>Return boolean of the validness of the data.</returns
        private bool InputValidation()
        {
            bool valid = true;

            if (PickerOffice.SelectedItem == null)
                valid = false;
            if (PickerInstructionLanguage.SelectedValue == null)
                valid = false;
            if (PickerUILanguage.SelectedValue == null)
                valid = false;
            if (string.IsNullOrWhiteSpace(TextTitle.Text))
                valid = false;
            if (string.IsNullOrWhiteSpace(TextShortIntro.Text))
                valid = false;
            if (string.IsNullOrWhiteSpace(TextIntro.Text))
                valid = false;
            if (string.IsNullOrWhiteSpace(TextIdentificationCode.Text))
                valid = false;
            if (string.IsNullOrWhiteSpace(TextHours.Text))
                valid = false;

            if (string.IsNullOrWhiteSpace(TextSeconds.Text) || string.IsNullOrWhiteSpace(TextMinutes.Text))
                valid = false;
            else if (int.Parse(TextSeconds.Text) < 0 || int.Parse(TextSeconds.Text) > 59)
                valid = false;
            else if (int.Parse(TextMinutes.Text) < 0 || int.Parse(TextMinutes.Text) > 59)
                valid = false;

            try
            {
                decimal.Parse(TextMinScore.Text);
            }
            catch (Exception)
            {
                valid = false;
            }

            if (!valid) MessageBox.Show(model.ValidationError, "Quiz");

            return valid;
        }

        /// <summary>
        /// In case a quiz is validated, update the quiz and push into the database.
        /// Thereafter, the user is notified and this window is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (!InputValidation()) return;

            Office_Application App = (Office_Application) PickerOffice.SelectedItem;
            Quiz updatedQuiz = new Quiz
            {
                Id = quiz.Id,
                Office_Application_Id = App.Id,
                Instruction_Language_Id = (int)PickerInstructionLanguage.SelectedValue,
                Userinterface_Language_Id = (int)PickerUILanguage.SelectedValue,
                Title = TextTitle.Text,
                Short_Intro = TextShortIntro.Text,
                Intro = TextIntro.Text,
                Default_Time_Limit = new TimeSpan(int.Parse(TextHours.Text), int.Parse(TextMinutes.Text), int.Parse(TextSeconds.Text)),
                Default_Minimum_Score = decimal.Parse(TextMinScore.Text),
                Identification_Code = TextIdentificationCode.Text,
                Creation_Timestamp = quiz.Creation_Timestamp,
                ReplicationKey = quiz.ReplicationKey
            };

            await HttpClientHelper<Quiz>.HttpClientPatchAsync(updatedQuiz, "Quiz");
            MessageBox.Show(model.QuizUpdated, "Quiz");

            _quizzesUserControl.GetQuizzes();
            Close();
        }

        /// <summary>
        /// Close this window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }    
    }
}