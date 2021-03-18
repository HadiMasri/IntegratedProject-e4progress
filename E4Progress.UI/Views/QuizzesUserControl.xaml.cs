using E4Progress.DAL.Entities;
using E4Progress.Shared.ViewModels;
using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;
using E4Progress.UI.ViewModelsdata;
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
    /// Interaction logic for QuizzesUserControl.xaml
    /// </summary>
    public partial class QuizzesUserControl : UserControl
    {
        readonly QuizzesUserControlViewModel model = new QuizzesUserControlViewModel();
        readonly Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        List<Quiz> Quizzes;
        List<Quiz_Question> QuizQuestions;
        List<QuizViewModel> QuizViews;
        List<Office_ApplicationViewModel> Applications;
        List<Translation_LanguageViewModel> Languages;

        int pageIndex = 1;
        private int numberOfRowsPerPage;
        private enum PagingMode { First = 1, Next = 2, Previous = 3, Last = 4, PageCountChange = 5 };
        List<QuizViewModel> QuizList = new List<QuizViewModel>();

        public QuizzesUserControl()
        {
            InitializeComponent();

            FillRowsCombo();
            GetQuizzes();
        }

        /// <summary>
        /// Fetch all quizzes and amount of questions per quiz from the database.
        /// Display all quizzes in the datagrid.
        /// </summary>
        public async void GetQuizzes()
        {
            DataGridQuiz.ItemsSource = null;
            QuizList.Clear();

            Quizzes = await HttpClientHelper<Quiz>.HttpClientGetAsync("quiz");
            QuizQuestions = await HttpClientHelper<Quiz_Question>.HttpClientGetAsync("quizquestion");
            Applications = await HttpClientHelper<Office_ApplicationViewModel>.HttpClientGetAsync("OfficeApplication");
            QuizViews = new List<QuizViewModel>();
            Languages = services.service.GetLanguageTranslatedBySelectedLanguageId(Convert.ToInt32(config.AppSettings.Settings["languageId"].Value)).Result;

            OfficeAppFilterCombo.ItemsSource = Applications;
            InstructieTaalFilterCombo.ItemsSource = Languages;
            GebruikerTaalFilterCombo.ItemsSource = Languages;

            foreach (Quiz quiz in Quizzes)
            {
                QuizViews.Add(new QuizViewModel(
                    quiz.Id,
                    GetOfficeApplication(quiz.Office_Application_Id),
                    GetLanguage(quiz.Instruction_Language_Id),
                    GetLanguage(quiz.Userinterface_Language_Id),
                    quiz.Identification_Code,
                    quiz.Title,
                    QuizQuestions.FindAll(qq => qq.Quiz_Id == quiz.Id).Count
                ));

                QuizList.Add(new QuizViewModel(
                    quiz.Id,
                    GetOfficeApplication(quiz.Office_Application_Id),
                    GetLanguage(quiz.Instruction_Language_Id),
                    GetLanguage(quiz.Userinterface_Language_Id),
                    quiz.Identification_Code,
                    quiz.Title,
                    QuizQuestions.FindAll(qq => qq.Quiz_Id == quiz.Id).Count
                ));

                DataGridQuiz.ItemsSource = QuizList.Take(numberOfRowsPerPage);
                int count = QuizList.Take(numberOfRowsPerPage).Count();
                TxtPageInfo.Text = count + " / " + QuizList.Count;
            }
        }

        /// <summary>
        /// Define NumberOfRow options in the pagination tab for the DataGrid.
        /// </summary>
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
        /// Open a newQuizDialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemNew_Click(object sender, RoutedEventArgs e)
        {
            NewQuizDialog newQuizDialog = new NewQuizDialog(this);
            newQuizDialog.ShowDialog();

            DataGridQuiz.ItemsSource = QuizList.Take(numberOfRowsPerPage);
            int count = QuizList.Take(numberOfRowsPerPage).Count();
            TxtPageInfo.Text = count + " / " + QuizList.Count;
        }

        /// <summary>
        /// Open a QuizQuestionDialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemQuestions_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridQuiz.SelectedItem == null) return;

            QuizViewModel quizView = (QuizViewModel)DataGridQuiz.SelectedItem;
            Quiz quiz = Quizzes.Find(q => q.Id == quizView.Id);

            QuizQuestionDialog quizQuestionDialog = new QuizQuestionDialog(quiz, this);
            quizQuestionDialog.ShowDialog();

            DataGridQuiz.ItemsSource = QuizList.Take(numberOfRowsPerPage);
            int count = QuizList.Take(numberOfRowsPerPage).Count();
            TxtPageInfo.Text = count + " / " + QuizList.Count;
        }

        /// <summary>
        /// Open an UpdateQuizDialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridQuiz.SelectedItem == null) return;

            QuizViewModel quizView = (QuizViewModel) DataGridQuiz.SelectedItem;
            Quiz quiz = Quizzes.Find(q => q.Id == quizView.Id);

            UpdateQuizDialog updateQuizDialog = new UpdateQuizDialog(quiz, this);
            updateQuizDialog.ShowDialog();

            DataGridQuiz.ItemsSource = QuizList.Take(numberOfRowsPerPage);
            int count = QuizList.Take(numberOfRowsPerPage).Count();
            TxtPageInfo.Text = count + " / " + QuizList.Count;
        }

        /// <summary>
        /// Get the name of an Office Application.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private string GetOfficeApplication(int id)
        {
            Office_ApplicationViewModel app = Applications.Find(app => app.Id == id);
            return app.Name;
        }

        /// <summary>
        /// Get the language of the session.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private string GetLanguage(int code)
        {
            string language = "";

            switch (code)
            {
                case 1:
                    language = model.English;
                    break;
                case 2:
                    language = model.Dutch;
                    break;
                case 3:
                    language = model.French;
                    break;
            }

            return language;
        }

        /// <summary>
        /// Filter data in DataGrid based on all criterias.
        /// </summary>
        private void FilterData()
        {
            List<QuizViewModel> filteredQuizViews = QuizViews;
            Office_ApplicationViewModel app = (Office_ApplicationViewModel) OfficeAppFilterCombo.SelectedItem;
            string title = QuizTitleFilter.Text.ToLower();
            Translation_LanguageViewModel instructionLanguage = (Translation_LanguageViewModel) InstructieTaalFilterCombo.SelectedItem;
            Translation_LanguageViewModel uiLanguage = (Translation_LanguageViewModel) GebruikerTaalFilterCombo.SelectedItem;
            string code = QuizCodeFilter.Text.ToLower();

            if (app != null)
                filteredQuizViews = filteredQuizViews.FindAll(quiz => quiz.Office_Application == app.Name);

            if (!string.IsNullOrEmpty(title))
                filteredQuizViews = filteredQuizViews.FindAll(quiz => quiz.Title.ToLower().Contains(title));

            if (instructionLanguage != null)
                filteredQuizViews = filteredQuizViews.FindAll(quiz => quiz.Instruction_Language == instructionLanguage.Translation);

            if (uiLanguage != null)
                filteredQuizViews = filteredQuizViews.FindAll(quiz => quiz.Userinterface_Language == uiLanguage.Translation);

            if (!string.IsNullOrEmpty(code))
                filteredQuizViews = filteredQuizViews.FindAll(quiz => quiz.Identification_Code.ToLower().Contains(code));

            DataGridQuiz.Items.Refresh();
            DataGridQuiz.ItemsSource = filteredQuizViews.Take(numberOfRowsPerPage);
            int count = filteredQuizViews.Take(numberOfRowsPerPage).Count();
            TxtPageInfo.Text = count + " / " + filteredQuizViews.Count;
        }

        /// <summary>
        /// Filter data on Office Application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OfficeAppFilterCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();
        }

        /// <summary>
        /// Filter data on Title.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuizTitleFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterData();
        }

        /// <summary>
        /// Filter data on Instruction Language.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstructieTaalFilterCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();
        }

        /// <summary>
        /// Filter data on UserInterface Language.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GebruikerTaalFilterCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();
        }

        /// <summary>
        /// Filter data on Identification Code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuizCodeFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterData();
        }

        /// <summary>
        /// Reset applied filters and display all Quizzes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetFilters_Click(object sender, RoutedEventArgs e)
        {
            // Reset filters
            OfficeAppFilterCombo.Text = "";
            QuizTitleFilter.Text = "";
            InstructieTaalFilterCombo.Text = "";
            GebruikerTaalFilterCombo.Text = "";
            QuizCodeFilter.Text = "";

            // Reset DataGrid
            //DataGridQuiz.ItemsSource = QuizViews;
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

        private void itemDetails_Click(object sender, RoutedEventArgs e)
        {
            QuizViewModel quizView = (QuizViewModel)DataGridQuiz.SelectedItem;
            Quiz quiz = Quizzes.Find(q => q.Id == quizView.Id);
            QuizDetailsUserControl quizDetails = new QuizDetailsUserControl(this, quiz);
            FilterView.Visibility = Visibility.Hidden;
            QuizView.Visibility = Visibility.Hidden;
            PaginationGrid.Visibility = Visibility.Hidden;
            DetailView.Children.Add(quizDetails);
            DetailView.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Functionality for the pagination.
        /// Display x amount of rows.
        /// </summary>
        /// <param name="mode">Amount of rows to display</param>
        private void Navigate(int mode)
        {
            int count;
            switch (mode)
            {
                case (int)PagingMode.Next:
                    BtnPrev.IsEnabled = true;
                    BtnFirst.IsEnabled = true;
                    if (QuizList.Count >= (pageIndex * numberOfRowsPerPage))
                    {
                        if (QuizList.Skip(pageIndex *
                        numberOfRowsPerPage).Take(numberOfRowsPerPage).Count() == 0)
                        {
                            DataGridQuiz.ItemsSource = null;
                            DataGridQuiz.ItemsSource = QuizList.Skip((pageIndex *
                            numberOfRowsPerPage) - numberOfRowsPerPage).Take(numberOfRowsPerPage);
                            count = (pageIndex * numberOfRowsPerPage) +
                            (QuizList.Skip(pageIndex *
                            numberOfRowsPerPage).Take(numberOfRowsPerPage)).Count();
                        }
                        else
                        {
                            DataGridQuiz.ItemsSource = null;
                            DataGridQuiz.ItemsSource = QuizList.Skip(pageIndex *
                            numberOfRowsPerPage).Take(numberOfRowsPerPage);
                            count = (pageIndex * numberOfRowsPerPage) +
                            (QuizList.Skip(pageIndex *
                            numberOfRowsPerPage).Take(numberOfRowsPerPage)).Count();
                            pageIndex++;
                        }

                        TxtPageInfo.Text = count + " / " + QuizList.Count;
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
                        DataGridQuiz.ItemsSource = null;
                        if (pageIndex == 1)
                        {
                            DataGridQuiz.ItemsSource = QuizList.Take(numberOfRowsPerPage);
                            count = QuizList.Take(numberOfRowsPerPage).Count();
                            TxtPageInfo.Text = count + " / " + QuizList.Count;
                        }
                        else
                        {
                            DataGridQuiz.ItemsSource = QuizList.Skip
                            (pageIndex * numberOfRowsPerPage).Take(numberOfRowsPerPage);
                            count = Math.Min(pageIndex * numberOfRowsPerPage, QuizList.Count);
                            TxtPageInfo.Text = count + " / " + QuizList.Count;
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
                    pageIndex = (QuizList.Count / numberOfRowsPerPage);
                    Navigate((int)PagingMode.Next);
                    break;

                case (int)PagingMode.PageCountChange:
                    pageIndex = 1;
                    numberOfRowsPerPage = Convert.ToInt32(CbNumberOfRows.SelectedItem);
                    DataGridQuiz.ItemsSource = null;
                    DataGridQuiz.ItemsSource = QuizList.Take(numberOfRowsPerPage);
                    count = (QuizList.Take(numberOfRowsPerPage)).Count();
                    TxtPageInfo.Text = count + " / " + QuizList.Count;
                    BtnNext.IsEnabled = true;
                    BtnLast.IsEnabled = true;
                    BtnPrev.IsEnabled = true;
                    BtnFirst.IsEnabled = true;
                    break;
            }
        }

        /// <summary>
        /// Display first row of the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFirst_Click(object sender, RoutedEventArgs e)
        {
            Navigate((int)PagingMode.First);
        }

        /// <summary>
        /// Display next row of the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Navigate((int)PagingMode.Next);
        }

        /// <summary>
        /// Display previous row of the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            Navigate((int)PagingMode.Previous);
        }

        /// <summary>
        /// Display last row of the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLast_Click(object sender, RoutedEventArgs e)
        {
            Navigate((int)PagingMode.Last);
        }

        /// <summary>
        /// Update amount of rows displayed based on selection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbNumberOfRows_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigate((int)PagingMode.PageCountChange);
        }
    }
}