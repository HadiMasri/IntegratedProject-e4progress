using E4Progress.DAL.Entities;
using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for QuizQuestionDialog.xaml
    /// </summary>
    public partial class QuizQuestionDialog : Window
    {
        readonly QuizQuestionDialogViewModel model = new QuizQuestionDialogViewModel();
        readonly QuizzesUserControl _quizzesUserControl;

        Quiz quiz;
        List<Question> allQuestions;
        List<Question> availableQuestions;
        List<Quiz_Question> allQuizQuestions;
        readonly ObservableCollection<Question> quizQuestions; 

        public QuizQuestionDialog(Quiz getQuiz, QuizzesUserControl quizzesUserControl)
        {
            InitializeComponent();

            quiz = getQuiz;
            availableQuestions = new List<Question>();
            allQuizQuestions = new List<Quiz_Question>();
            quizQuestions = new ObservableCollection<Question>();
            _quizzesUserControl = quizzesUserControl;
        }

        /// <summary>
        /// Load all questions and quizQuestions.
        /// Split questions into 2 parts:
        /// Questions that are already linked with the quiz (and shown in the right listBox).
        /// Questions that are available (and shown in the left listBox).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            allQuestions = await HttpClientHelper<Question>.HttpClientGetAsync("Question");
            allQuizQuestions = await HttpClientHelper<Quiz_Question>.HttpClientGetAsync("quizquestion");

            // Get all available questions
            foreach (Question q in allQuestions)
            {
                if (!allQuizQuestions.Exists(qq => qq.Quiz_Id == quiz.Id && qq.Question_Id == q.Id))
                    availableQuestions.Add(q);
            }

            // Get all taken questions
            List<Quiz_Question> takenQuestions = new List<Quiz_Question>();
            takenQuestions = allQuizQuestions.FindAll(qq => qq.Quiz_Id == quiz.Id);
            takenQuestions.Sort((x, y) => x.Sortorder.CompareTo(y.Sortorder));

            foreach (Quiz_Question qq in takenQuestions)
                quizQuestions.Add(allQuestions.Find(q => q.Id == qq.Question_Id));

            OverviewQuiz.ItemsSource = availableQuestions;
            OverviewQuestions.ItemsSource = quizQuestions;

            TextNumberOfQuestions.Text = $"{model.Questions}: {quizQuestions.Count}";
            TextQuizName.Text = $"{quiz.Title } \t ({quiz.Identification_Code})";
        }

        /// <summary>
        /// Apply search filter based on questions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterQuizName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string filter = FilterQuizName.Text;
            List<Question> filteredQuestions = allQuestions.FindAll(q => q.QuestionText.Contains(filter));

            if (string.IsNullOrEmpty(filter))
                OverviewQuiz.ItemsSource = allQuestions;
            else
                OverviewQuiz.ItemsSource = filteredQuestions;
        }

        /// <summary>
        /// DoubleClick on a question to link it to a Quiz. 
        /// Said question gets moved to the right listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OverviewQuiz_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (OverviewQuiz.SelectedIndex == -1) return;
            Question question = (Question) OverviewQuiz.SelectedItem;

            availableQuestions.Remove(question);
            quizQuestions.Add(question);

            // Refresh UI
            OverviewQuiz.Items.Refresh();
            TextNumberOfQuestions.Text = $"{model.Questions}: {quizQuestions.Count}";
        }

        /// <summary>
        /// Selected question gets moved up in the sortOrder of a quiz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUp_Click(object sender, RoutedEventArgs e)
        {
            if (OverviewQuestions.SelectedIndex < 1) return;

            Question question = (Question) OverviewQuestions.SelectedItem;
            quizQuestions.Move(quizQuestions.IndexOf(question), quizQuestions.IndexOf(question) - 1);
        }

        /// <summary>
        /// Selected question gets moved down in the sortOrder of a quiz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDown_Click(object sender, RoutedEventArgs e)
        {
            if (OverviewQuestions.SelectedIndex == -1 || OverviewQuestions.SelectedIndex + 1 == quizQuestions.Count) return;

            Question question = (Question) OverviewQuestions.SelectedItem;
            quizQuestions.Move(quizQuestions.IndexOf(question), quizQuestions.IndexOf(question) + 1);
        }

        /// <summary>
        /// Selected question gets deleted from a quiz.
        /// Said question gets moved back into the pool of available questions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (OverviewQuestions.SelectedIndex == -1) return;

            Question question = (Question) OverviewQuestions.SelectedItem;
            quizQuestions.Remove(question);

            // Refresh UI
            availableQuestions.Add(question);
            OverviewQuiz.Items.Refresh();
            TextNumberOfQuestions.Text = $"{model.Questions}: {quizQuestions.Count}";
        }

        /// <summary>
        /// Group list of questions in 3 lists:
        /// Updated questions, new questions and deleted questions.
        /// Push changes to DB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {          
            List<Quiz_Question> newQuestions = new List<Quiz_Question>();
            List<Quiz_Question> updateQuestions = new List<Quiz_Question>();
            List<Quiz_Question> removeQuestions = new List<Quiz_Question>();
            List<Quiz_Question> originalQuestions = new List<Quiz_Question>();

            Question question;
            Quiz_Question quizQuestion;
            originalQuestions = allQuizQuestions.FindAll(qq => qq.Quiz_Id == quiz.Id);

            // Check if questions are already linked to the quiz.
            for (int i = 0; i < quizQuestions.Count; i++)
            {
                question = quizQuestions[i];

                if (originalQuestions.Exists(qq => qq.Question_Id == question.Id))
                {
                    quizQuestion = originalQuestions.Find(qq => qq.Question_Id == question.Id);
                    quizQuestion.Sortorder = i + 1;
                    updateQuestions.Add(quizQuestion);
                }
                else
                    newQuestions.Add(new Quiz_Question
                    {
                        Quiz_Id = quiz.Id,
                        Question_Id = question.Id,
                        Sortorder = i + 1
                    });
            }

            // Check if question is removed from the quiz.
            foreach (Quiz_Question qq in originalQuestions)
            {
                if (!updateQuestions.Exists(q => q.Question_Id == qq.Question_Id))
                    removeQuestions.Add(originalQuestions.Find(qq => qq.Question_Id == qq.Question_Id));
            }

            await HttpClientHelper<Quiz_Question>.HttpClientPutAsync(removeQuestions, "quizquestion");
            await HttpClientHelper<Quiz_Question>.HttpClientPatchAsync(updateQuestions, "quizquestion");
            await HttpClientHelper<Quiz_Question>.HttpClientPostAsync(newQuestions, "quizquestion");

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