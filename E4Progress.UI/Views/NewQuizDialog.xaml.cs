using E4Progress.DAL.Entities;
using E4Progress.Shared.ViewModels;
using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for NewQuizDialog.xaml
    /// </summary>
    public partial class NewQuizDialog : Window
    {
        readonly Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        readonly NewQuizDialogViewModel model = new NewQuizDialogViewModel();
        readonly QuizzesUserControl _quizzesUserControl;

        List<Office_Application> Apps;
        List<Translation_LanguageViewModel> Languages;

        public NewQuizDialog(QuizzesUserControl quizzesUserControl)
        {
            InitializeComponent();
            _quizzesUserControl = quizzesUserControl;
        }

        /// <summary>
        /// Load data for languages and Office Applications.
        /// Fill comboboxes with said data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Apps = await HttpClientHelper<Office_Application>.HttpClientGetAsync("OfficeApplication");
            Languages = services.service.GetLanguageTranslatedBySelectedLanguageId(Convert.ToInt32(config.AppSettings.Settings["languageId"].Value)).Result;

            PickerOffice.ItemsSource = Apps;
            PickerInstructionLanguage.ItemsSource = Languages;
            PickerUILanguage.ItemsSource = Languages;
        }

        /// <summary>
        /// In case a quiz is validated, create a new quiz and push into the database.
        /// Thereafter, the user is notified and this window is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (!InputValidation()) return;

            Office_Application App = (Office_Application) PickerOffice.SelectedItem;
            Quiz quiz = new Quiz
            {
                Office_Application_Id = App.Id,
                Instruction_Language_Id = (int) PickerInstructionLanguage.SelectedValue,
                Userinterface_Language_Id = (int) PickerUILanguage.SelectedValue,
                Title = TextTitle.Text,
                Short_Intro = TextShortIntro.Text,
                Intro = TextIntro.Text,
                Default_Time_Limit = new TimeSpan(int.Parse(TextHours.Text), int.Parse(TextMinutes.Text), int.Parse(TextSeconds.Text)),
                Default_Minimum_Score = decimal.Parse(TextMinScore.Text),
                Identification_Code = TextIdentificationCode.Text,
                Creation_Timestamp = DateTime.Today,
                ReplicationKey = Guid.NewGuid()
            };

            await HttpClientHelper<Quiz>.HttpClientPostAsync(quiz, "Quiz");
            MessageBox.Show(model.QuizCreated ,"Quiz");

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

        /// <summary>
        /// Validate all input fields on business rules.
        /// </summary>
        /// <returns>Return boolean of the validness of the data.</returns>
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
        /// Validation method to guarantee numeric input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Validation method to guarantee text input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lettersValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
