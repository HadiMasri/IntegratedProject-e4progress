using E4Progress.Shared.ViewModels;
using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for QuestionsUserControl.xaml
    /// </summary>
    public partial class QuestionsUserControl : UserControl
    {
        List<QuestionViewModel> QuestionWithTranlation = new List<QuestionViewModel>();
        QuestionUserControlViewModel questionUserControlViewModel = new QuestionUserControlViewModel();

        int pageIndex = 1;
        private int numberOfRowsPerPage;
        private enum PagingMode { First = 1, Next = 2, Previous = 3, Last = 4, PageCountChange = 5 };
        List<QuestionViewModel> QuestionList = new List<QuestionViewModel>();

        public QuestionsUserControl()
        {
            InitializeComponent();
            GetQuestionsAsync();
            Get_Question_TypeAsync();
            GetOfficeApplicationAsync();
            GetLanguageAsync();

            FillRowsCombo();
        }
        /// <summary>
        /// get all question types and fill them in combobox
        /// </summary>
        public async void Get_Question_TypeAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<QuestionType_TranslationViewModel> questionTypes = await HttpClientHelper<QuestionType_TranslationViewModel>.GetItemsTranslatedBySelectedLanguageId("QuestionType", Convert.ToInt32(config.AppSettings.Settings["languageId"].Value));
            questionTypeCombo.ItemsSource = questionTypes;
        }
        /// <summary>
        /// get all office application and fill them in combobox
        /// </summary>
        public async void GetOfficeApplicationAsync()
        {
            List<Office_ApplicationViewModel> officeApplication = await HttpClientHelper<Office_ApplicationViewModel>.HttpClientGetAsync("OfficeApplication");
            officeApplicationCombo.ItemsSource = officeApplication;
        }
        public async void GetLanguageAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Translation_LanguageViewModel> language = services.service.GetLanguageTranslatedBySelectedLanguageId(Convert.ToInt32(config.AppSettings.Settings["languageId"].Value)).Result;
            instructionLanguageCombo.ItemsSource = language;
            userLanguageCombo.ItemsSource = language;
        }
        /// <summary>
        /// get all questions and fill them in datagrid of questions
        /// </summary>
        public async void GetQuestionsAsync()
        {
            questionDataGrid.ItemsSource = null;
            QuestionList.Clear();
            QuestionWithTranlation.Clear();
            List<QuestionViewModel> Questions = await HttpClientHelper<QuestionViewModel>.HttpClientGetAsync("Question");
            Questions.Reverse();
            foreach (var item in Questions)
            {

                var Instruction_Language_Name = item.Instruction_Language.Native_Name;
                var UserInterface_Language_Name = item.UserInterface_Language.Native_Name;
                var QuestionTypeName = item.Question_Type.Name;
                switch (QuestionTypeName)
                {
                    case "True/false question":
                        QuestionTypeName = questionUserControlViewModel.QuestionTypeName;
                        break;
                    case "Vrai/faux question":
                        QuestionTypeName = questionUserControlViewModel.QuestionTypeName;
                        break;
                    case "Waar/onwaar vraag":
                        QuestionTypeName = questionUserControlViewModel.QuestionTypeName;
                        break;
                    default:
                        break;
                }
                switch (Instruction_Language_Name)
                {
                    case "English":
                        Instruction_Language_Name = questionUserControlViewModel.English;
                        break;
                    case "Dutch":
                        Instruction_Language_Name = questionUserControlViewModel.Dutch;
                        break;
                    case "French":
                        Instruction_Language_Name = questionUserControlViewModel.French;
                        break;

                    case "Engels":
                        Instruction_Language_Name = questionUserControlViewModel.English;
                        break;
                    case "Nederlands":
                        Instruction_Language_Name = questionUserControlViewModel.Dutch;
                        break;
                    case "Frans":
                        Instruction_Language_Name = questionUserControlViewModel.French;
                        break;

                    case "Anglais":
                        Instruction_Language_Name = questionUserControlViewModel.English;
                        break;
                    case "Néerlandais":
                        Instruction_Language_Name = questionUserControlViewModel.Dutch;
                        break;
                    case "Français":
                        Instruction_Language_Name = questionUserControlViewModel.French;
                        break;
                    default:
                        break;
                }
                switch (UserInterface_Language_Name)
                {
                    case "English":
                        UserInterface_Language_Name = questionUserControlViewModel.English;
                        break;
                    case "Dutch":
                        UserInterface_Language_Name = questionUserControlViewModel.Dutch;
                        break;
                    case "French":
                        UserInterface_Language_Name = questionUserControlViewModel.French;
                        break;

                    case "Engels":
                        UserInterface_Language_Name = questionUserControlViewModel.English;
                        break;
                    case "Nederlands":
                        UserInterface_Language_Name = questionUserControlViewModel.Dutch;
                        break;
                    case "Frans":
                        UserInterface_Language_Name = questionUserControlViewModel.French;
                        break;

                    case "Anglais":
                        UserInterface_Language_Name = questionUserControlViewModel.English;
                        break;
                    case "Néerlandais":
                        UserInterface_Language_Name = questionUserControlViewModel.Dutch;
                        break;
                    case "Français":
                        UserInterface_Language_Name = questionUserControlViewModel.French;
                        break;
                    default:
                        break;
                }
                QuestionWithTranlation.Add(new QuestionViewModel
                {
                    Id = item.Id,
                    OfficeApplicationName = item.Office_Application.Name,
                    Title = item.Title,
                    InstructionLanguageName = Instruction_Language_Name,
                    UserInterfaceLanguageName = UserInterface_Language_Name,
                    Notes = item.Notes,
                    QuestionTypeName = QuestionTypeName,
                    Question_Formulation_TypeName = item.Question_Formulation_Type.Name,
                    Is_Master_Question = item.Is_Master_Question,
                    Version_Number = item.Version_Number,
                    QuestionText = item.QuestionText,
                    ReplicationKey = item.ReplicationKey
                });

                QuestionList.Add(new QuestionViewModel
                {
                    Id = item.Id,
                    OfficeApplicationName = item.Office_Application.Name,
                    Title = item.Title,
                    InstructionLanguageName = Instruction_Language_Name,
                    UserInterfaceLanguageName = UserInterface_Language_Name,
                    Notes = item.Notes,
                    QuestionTypeName = QuestionTypeName,
                    Question_Formulation_TypeName = item.Question_Formulation_Type.Name,
                    Is_Master_Question = item.Is_Master_Question,
                    Version_Number = item.Version_Number,
                    QuestionText = item.QuestionText,
                    ReplicationKey = item.ReplicationKey,
                });

                questionDataGrid.ItemsSource = QuestionList.Take(numberOfRowsPerPage);
                int count = QuestionList.Take(numberOfRowsPerPage).Count();
                TxtPageInfo.Text = count + " / " + QuestionList.Count;                
            }

        }

        public void FillRowsCombo()
        {
            CbNumberOfRows.Items.Add("10");
            CbNumberOfRows.Items.Add("20");
            CbNumberOfRows.Items.Add("30");
            CbNumberOfRows.Items.Add("40");
            CbNumberOfRows.Items.Add("50");
            CbNumberOfRows.SelectedIndex = 4;
        }

        /// <summary>
        /// for filter the data in the datagrid of questions
        /// </summary>
        private void FilterData()
        {
            List<QuestionViewModel> filteredQuestionViews = QuestionWithTranlation;
            Office_ApplicationViewModel app = (Office_ApplicationViewModel)officeApplicationCombo.SelectedItem;
            Translation_LanguageViewModel instructionLanguage = (Translation_LanguageViewModel)instructionLanguageCombo.SelectedItem;
            Translation_LanguageViewModel uiLanguage = (Translation_LanguageViewModel)userLanguageCombo.SelectedItem;
            string title = titleTxt.Text;
            string note = noteTxt.Text;


            if (app != null)
                filteredQuestionViews = filteredQuestionViews.FindAll(question => question.OfficeApplicationName == app.Name);

            if (!string.IsNullOrEmpty(title))
                filteredQuestionViews = filteredQuestionViews.FindAll(question => question.Title.ToLower().Contains(title.ToLower()));

            if (!string.IsNullOrEmpty(note))
                filteredQuestionViews = filteredQuestionViews.FindAll(question => question.Notes.ToLower().Contains(note.ToLower()));

            if (instructionLanguage != null)
                filteredQuestionViews = filteredQuestionViews.FindAll(question => question.InstructionLanguageName == instructionLanguage.Translation);

            if (uiLanguage != null)
                filteredQuestionViews = filteredQuestionViews.FindAll(question => question.UserInterfaceLanguageName == uiLanguage.Translation);
            questionDataGrid.Items.Refresh();
            questionDataGrid.ItemsSource = filteredQuestionViews.Take(numberOfRowsPerPage);
            int count = filteredQuestionViews.Take(numberOfRowsPerPage).Count();
            TxtPageInfo.Text = count + " / " + filteredQuestionViews.Count;
        }

        /// <summary>
        /// show new question dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_Question(object sender, RoutedEventArgs e)
        {
            NewQuestionDialog questionDialog = new NewQuestionDialog(this);
            questionDialog.Show();
        }

        /// <summary>
        /// show update question dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Question(object sender, RoutedEventArgs e)
        {
            var question = (QuestionViewModel)questionDataGrid.SelectedItem;
            if (question != null)
            {
                UpdateQuestionDialog updateQuestionDialog = new UpdateQuestionDialog(question, this);
                updateQuestionDialog.Show();
            }
        }

        /// <summary>
        /// for delete the selected question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Delete_Question(object sender, RoutedEventArgs e)
        {
            var question = (QuestionViewModel)questionDataGrid.SelectedItem;
           await HttpClientHelper<QuestionViewModel>.HttpClientDeleteAsync(question.Id, "Question");
            GetQuestionsAsync();
        }

        private void titleTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterData();
        }

        private void questionTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();
        }

        private void officeApplicationCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();
        }

        private void instructionLanguageCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();
        }

        private void userLanguageCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();
        }

        private void noteTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterData();
        }
        private void Reset_Filter(object sender, RoutedEventArgs e)
        {
            userLanguageCombo.Text = "";
            instructionLanguageCombo.Text = "";
            officeApplicationCombo.Text = "";
            titleTxt.Text = "";
            //QuestionWithTranlation.Clear();
            noteTxt.Text = "";
            //GetQuestionsAsync();
        }
        /// <summary>
        /// Letter validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lettersValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Navigate(int mode)
        {
            int count;
            switch (mode)
            {
                case (int)PagingMode.Next:
                    BtnPrev.IsEnabled = true;
                    BtnFirst.IsEnabled = true;
                    if (QuestionList.Count >= (pageIndex * numberOfRowsPerPage))
                    {
                        if (QuestionList.Skip(pageIndex *
                        numberOfRowsPerPage).Take(numberOfRowsPerPage).Count() == 0)
                        {
                            questionDataGrid.ItemsSource = null;
                            questionDataGrid.ItemsSource = QuestionList.Skip((pageIndex *
                            numberOfRowsPerPage) - numberOfRowsPerPage).Take(numberOfRowsPerPage);
                            count = (pageIndex * numberOfRowsPerPage) +
                            (QuestionList.Skip(pageIndex *
                            numberOfRowsPerPage).Take(numberOfRowsPerPage)).Count();
                        }
                        else
                        {
                            questionDataGrid.ItemsSource = null;
                            questionDataGrid.ItemsSource = QuestionList.Skip(pageIndex *
                            numberOfRowsPerPage).Take(numberOfRowsPerPage);
                            count = (pageIndex * numberOfRowsPerPage) +
                            (QuestionList.Skip(pageIndex *
                            numberOfRowsPerPage).Take(numberOfRowsPerPage)).Count();
                            pageIndex++;
                        }

                        TxtPageInfo.Text = count + " / " + QuestionList.Count;
                    }

                    else
                    {
                        BtnNext.IsEnabled = false;
                        BtnLast.IsEnabled = false;
                    }

                    break;
                case (int)PagingMode.Previous:
                    BtnNext.IsEnabled = true;
                    BtnLast.IsEnabled = true;
                    if (pageIndex > 1)
                    {
                        pageIndex -= 1;
                        questionDataGrid.ItemsSource = null;
                        if (pageIndex == 1)
                        {
                            questionDataGrid.ItemsSource = QuestionList.Take(numberOfRowsPerPage);
                            count = QuestionList.Take(numberOfRowsPerPage).Count();
                            TxtPageInfo.Text = count + " / " + QuestionList.Count;
                        }
                        else
                        {
                            questionDataGrid.ItemsSource = QuestionList.Skip
                            (pageIndex * numberOfRowsPerPage).Take(numberOfRowsPerPage);
                            count = Math.Min(pageIndex * numberOfRowsPerPage, QuestionList.Count);
                            TxtPageInfo.Text = count + " / " + QuestionList.Count;
                        }
                    }
                    else
                    {
                        BtnPrev.IsEnabled = false;
                        BtnFirst.IsEnabled = false;
                    }
                    break;

                case (int)PagingMode.First:
                    pageIndex = 2;
                    Navigate((int)PagingMode.Previous);
                    break;
                case (int)PagingMode.Last:
                    pageIndex = (QuestionList.Count / numberOfRowsPerPage);
                    Navigate((int)PagingMode.Next);
                    break;

                case (int)PagingMode.PageCountChange:
                    pageIndex = 1;
                    numberOfRowsPerPage = Convert.ToInt32(CbNumberOfRows.SelectedItem);
                    questionDataGrid.ItemsSource = null;
                    questionDataGrid.ItemsSource = QuestionList.Take(numberOfRowsPerPage);
                    count = (QuestionList.Take(numberOfRowsPerPage)).Count();
                    TxtPageInfo.Text = count + " / " + QuestionList.Count;
                    BtnNext.IsEnabled = true;
                    BtnLast.IsEnabled = true;
                    BtnPrev.IsEnabled = true;
                    BtnFirst.IsEnabled = true;
                    break;
            }
        }

        private void BtnFirst_Click(object sender, RoutedEventArgs e)
        {
            Navigate((int)PagingMode.First);
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Navigate((int)PagingMode.Next);
        }

        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            Navigate((int)PagingMode.Previous);
        }

        private void BtnLast_Click(object sender, RoutedEventArgs e)
        {
            Navigate((int)PagingMode.Last);
        }

        private void CbNumberOfRows_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigate((int)PagingMode.PageCountChange);
        }
    }
}
