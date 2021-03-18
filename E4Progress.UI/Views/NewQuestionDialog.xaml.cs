using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using E4Progress.Shared.ViewModels;
using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for NewQuestionDialog.xaml
    /// </summary>
    public partial class NewQuestionDialog : Window
    {
        private readonly QuestionsUserControl _questionsUserControl;

        public NewQuestionDialog(QuestionsUserControl questionsUserControl)
        {
            InitializeComponent();
            Get_Question_TypeAsync();
            _questionsUserControl = questionsUserControl;
            Get_Model_LevelAsync();
            Get_Question_Formulation_TypeAsync();
            GetLanguageAsync();
            GetOfficeApplicationAsync();
            GetMasterQuestionsAsync();
            getAllThemas();
        }

        /// <summary>
        /// for create new question in database with learning goal and pre knowledge skills
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_Question(object sender, RoutedEventArgs e)
        {
            if (validation())
            {


                QuestionViewModel question = new QuestionViewModel();
                var Question_Type = (QuestionType_TranslationViewModel)questionTypeCombo.SelectedItem;
                question.Question_TypeId = Question_Type.QuestionTypeId;
                var Question_Formulation_Type = (Question_Formulation_Type_TranslationViewModel)questionFormulationTypeCombo.SelectedItem;
                question.Question_Formulation_TypeId = Question_Formulation_Type.Question_Formulation_TypeId;
                var Office_Application = (Office_ApplicationViewModel)officeApplicationCombo.SelectedItem;
                question.Office_ApplicationId = Office_Application.Id;
                question.Instruction_LanguageId = (int)instructionLanguageCombo.SelectedValue;
                question.UserInterface_LanguageId = (int)userLanguageCombo.SelectedValue;
                if (masterQuestionCheckBox.IsChecked == true)
                {
                    question.Is_Master_Question = true;
                    question.Master_QuestionId = null;
                }
                else
                {
                    question.Is_Master_Question = false;
                }
                question.Title = titleTxt.Text;
                question.Notes = noteTxt.Text;
                question.Version_Number = Convert.ToInt32(versionNrTxt.Text);
                question.QuestionText = questionTxt.Text;
                Guid guid = Guid.NewGuid();
                question.ReplicationKey = guid.ToString();
                question.Creation_timestamp = DateTime.Now;
                HttpClientHelper<QuestionViewModel>.HttpClientPostAsync(question, "Question");
                Thread.Sleep(100);
                _questionsUserControl.GetQuestionsAsync();
                postThemaIdWithQuestionId();
                addNewQuestionLearningGoal();
                addNewQuestionPreKnowledge();
                this.Close();
            }
            else
            {
                MessageBox.Show("An error has been occurred while creating new question ");
            }
        }

        private bool validation()
        {
            bool valid = true;
            if (questionTypeCombo.SelectedItem == null)
            {
                valid = false;
            }
            if (officeApplicationCombo.SelectedItem == null)
            {
                valid = false;
            }
            if (questionFormulationTypeCombo.SelectedItem == null)
            {
                valid = false;
            }
            if (instructionLanguageCombo.SelectedItem == null)
            {
                valid = false;
            }
            if (comboModelLevel.SelectedItem == null)
            {
                valid = false;
            }
            if (txtLearningGoal.Text == "")
            {
                valid = false;
            }
            if (txtSkills.Text == "")
            {
                valid = false;
            }
            if (questionTxt.Text == "")
            {
                valid = false;
            }
            if (titleTxt.Text == "")
            {
                valid = false;
            }
            return valid;
        }

        /// <summary>
        /// add new questionlearning when creating new question 
        /// </summary>
        public async void addNewQuestionLearningGoal()
        {
            List<QuestionViewModel> Questions = await HttpClientHelper<QuestionViewModel>.HttpClientGetAsync("Question");
            if (Questions.Count > 0)
            {
                QuestionViewModel question = Questions[Questions.Count - 1];
                Question_LearninggoalViewModel learninggoal = new Question_LearninggoalViewModel();
                var modelLevel = (Didactical_Model_Level_TranslationViewModel)comboModelLevel.SelectedItem;
                learninggoal.QuestionId = question.Id;
                learninggoal.Didactical_Model_LevelId = modelLevel.Didactical_Model_LevelId;
                learninggoal.Learninggoal = txtLearningGoal.Text;
                learninggoal.Notes = noteTxt.Text;
                if (isMesurableCheckBox.IsChecked == true)
                {
                    learninggoal.Is_Measurable = true;
                }
                else
                {
                    learninggoal.Is_Measurable = false;
                }
                await HttpClientHelper<Question_LearninggoalViewModel>.HttpClientPostAsync(learninggoal, "QuestionLearningGoal");
            }
        }
        /// <summary>
        /// add new preknowledge skills when creating new question 
        /// </summary>
        public async void addNewQuestionPreKnowledge()
        {
            List<QuestionViewModel> Questions = await HttpClientHelper<QuestionViewModel>.HttpClientGetAsync("Question");
            if (Questions.Count > 0)
            {
                QuestionViewModel question = Questions[Questions.Count - 1];
                Question_Pre_Knowledge_SkillViewModel preSkill = new Question_Pre_Knowledge_SkillViewModel();
                var modelLevel = (Didactical_Model_Level_TranslationViewModel)comboModelLevel.SelectedItem;
                preSkill.QuestionId = question.Id;
                preSkill.Skill = txtSkills.Text;
                await HttpClientHelper<Question_LearninggoalViewModel>.HttpClientPostAsync(preSkill, "QuestionPreKnowledge");
            }
        }
            public async void postThemaIdWithQuestionId()
        {
            Thread.Sleep(1);
            List<QuestionViewModel> Questions = await HttpClientHelper<QuestionViewModel>.HttpClientGetAsync("Question");
            if (Questions.Count>0)
            {
                QuestionViewModel question = Questions[Questions.Count - 1];
                Question_Content_ThemeViewModel question_Content_Theme = new Question_Content_ThemeViewModel();
                var question_Thema = (Content_Thema_ViewModel)comboThema.SelectedItem;
                question_Content_Theme.Content_ThemeId = question_Thema.Id;
                question_Content_Theme.QuestionId = question.Id;
                await HttpClientHelper<Question_Content_ThemeViewModel>.HttpClientPostAsync(question_Content_Theme, "QuestionThema");
            }
            
        }

        /// <summary>
        /// get all themas from database and fill it in combobox of themas
        /// </summary>
        private async void getAllThemas()
        {
            List<Content_Thema_ViewModel> themas = await HttpClientHelper<Content_Thema_ViewModel>.HttpClientGetAsync("Theme");
            comboThema.ItemsSource = themas;
        }
        public async void GetMasterQuestionsAsync()
        {
            List<QuestionViewModel> Questions = await HttpClientHelper<QuestionViewModel>.HttpClientGetAsync("Question");
            List<QuestionViewModel> masterQuestions = new List<QuestionViewModel>();
            foreach (var item in Questions)
            {
                if (item.Is_Master_Question == true)
                {
                    masterQuestions.Add(item);
                }
            }
            masterQuestionCombo.ItemsSource = masterQuestions;
        }

        /// <summary>
        /// get all question types from database and fill it in combobox
        /// </summary>
        public async void Get_Question_TypeAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<QuestionType_TranslationViewModel> questionTypes = await HttpClientHelper<QuestionType_TranslationViewModel>.GetItemsTranslatedBySelectedLanguageId("QuestionType", Convert.ToInt32(config.AppSettings.Settings["languageId"].Value));
            questionTypeCombo.ItemsSource = questionTypes;
        }
        /// <summary>
        /// get all model levels from database and fill it in combobox
        /// </summary>
        public async void Get_Model_LevelAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Didactical_Model_Level_TranslationViewModel> modelLevel = await HttpClientHelper<Didactical_Model_Level_TranslationViewModel>.GetItemsTranslatedBySelectedLanguageId("DidacticalModelLevel", Convert.ToInt32(config.AppSettings.Settings["languageId"].Value));
            comboModelLevel.ItemsSource = modelLevel;
        }
        /// <summary>
        /// get all question formulation type from database and fill it in combobox
        /// </summary>
        public async void Get_Question_Formulation_TypeAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Question_Formulation_Type_TranslationViewModel> questionTypes = await HttpClientHelper<Question_Formulation_Type_TranslationViewModel>.GetItemsTranslatedBySelectedLanguageId("QuestionFormulationType", Convert.ToInt32(config.AppSettings.Settings["languageId"].Value));
            questionFormulationTypeCombo.ItemsSource = questionTypes;
        }
        /// <summary>
        /// get all languages and fill it in combobox
        /// </summary>
        public async void GetLanguageAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Translation_LanguageViewModel> language = services.service.GetLanguageTranslatedBySelectedLanguageId(Convert.ToInt32(config.AppSettings.Settings["languageId"].Value)).Result;
            instructionLanguageCombo.ItemsSource = language;
            userLanguageCombo.ItemsSource = language;
        }
        /// <summary>
        /// get all office application and fill it in combobox
        /// </summary>
        public async void GetOfficeApplicationAsync()
        {
            List<Office_ApplicationViewModel> officeApplication = await HttpClientHelper<Office_ApplicationViewModel>.HttpClientGetAsync("OfficeApplication");
            officeApplicationCombo.ItemsSource = officeApplication;
        }
        /// <summary>
        /// get all master questions and fill it in combobox
        /// </summary>
        public async void GetMasterQuestionAsync()
        {
            List<QuestionViewModel> masterQuestion = await HttpClientHelper<QuestionViewModel>.HttpClientGetAsync("Question");
            masterQuestionCombo.ItemsSource = masterQuestion;
        }

        private void masterQuestionCheckBox_Checked(object sender, RoutedEventArgs e)
        {
                masterQuestionCombo.IsEnabled = false;
        }

        private void masterQuestionCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

                masterQuestionCombo.IsEnabled = true;
        }
        private void Close_Dialog(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// validation methode for numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
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
    }
}
