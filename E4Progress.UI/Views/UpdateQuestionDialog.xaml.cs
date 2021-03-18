using E4Progress.Shared.ViewModels;
using E4Progress.UI.Shared;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for UpdateQuestionDialog.xaml
    /// </summary>
    public partial class UpdateQuestionDialog : Window
    {
        QuestionViewModel question;
        private readonly QuestionsUserControl _questionsUserControl;
        List<Question_Content_ThemeViewModel> Question_Content_Theme_List = new List<Question_Content_ThemeViewModel>();
        Question_Content_ThemeViewModel Question_Content_Theme = new Question_Content_ThemeViewModel();
        List<Question_Pre_Knowledge_SkillViewModel> Question_Pre_Knowledge_Skill_List = new List<Question_Pre_Knowledge_SkillViewModel>();
        Question_Pre_Knowledge_SkillViewModel Question_Pre_Knowledge_Skill = new Question_Pre_Knowledge_SkillViewModel();
        List<Question_LearninggoalViewModel> Question_Learninggoal_List = new List<Question_LearninggoalViewModel>();
        Question_LearninggoalViewModel Question_Learninggoal = new Question_LearninggoalViewModel();


        public UpdateQuestionDialog(QuestionViewModel question, QuestionsUserControl questionsUserControl)
        {
            InitializeComponent();
            this.question = question;
            _questionsUserControl = questionsUserControl;
            getAllThemas();
            getQuestionContentThemaById();
            Get_Question_TypeAsync();
            Get_Question_Formulation_TypeAsync();
            GetLanguageAsync();
            getQuestionPreKnowledgeSkillByQuestionId();
            getQuestionLearningGoalByQuestionId();
            GetOfficeApplicationAsync();
            GetMasterQuestionsAsync();
            Get_Model_LevelAsync();
            fillQuestionInfo();
           
        }

        /// <summary>
        /// get all question types and fill them in the combobox
        /// </summary>
        public async void Get_Question_TypeAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<QuestionType_TranslationViewModel> questionTypes = await HttpClientHelper<QuestionType_TranslationViewModel>.GetItemsTranslatedBySelectedLanguageId("QuestionType", Convert.ToInt32(config.AppSettings.Settings["languageId"].Value));
            questionTypeCombo.ItemsSource = questionTypes;
        }
        /// <summary>
        /// called to update the QuestionLearningGoal of the question
        /// </summary>
        public async void updateQuestionLearningGoal()
        {
            var modelLevel = (Didactical_Model_Level_TranslationViewModel)comboModelLevel.SelectedItem;
            Question_Learninggoal.QuestionId = question.Id;
            Question_Learninggoal.Didactical_Model_LevelId = modelLevel.Didactical_Model_LevelId;
            Question_Learninggoal.Learninggoal = txtLearningGoal.Text;
            Question_Learninggoal.Notes = noteTxt.Text;
                if (isMesurableCheckBox.IsChecked == true)
                {
                Question_Learninggoal.Is_Measurable = true;
                }
                else
                {
                Question_Learninggoal.Is_Measurable = false;
                }
                await HttpClientHelper<Question_LearninggoalViewModel>.HttpClientPostAsync(Question_Learninggoal, "QuestionLearningGoal");
        }
        /// <summary>
        /// called to update the QuestionPreKnowledge of the question
        /// </summary>
        public async void updateQuestionPreKnowledge()
        {
                var modelLevel = (Didactical_Model_Level_TranslationViewModel)comboModelLevel.SelectedItem;
            Question_Pre_Knowledge_Skill.QuestionId = question.Id;
            Question_Pre_Knowledge_Skill.Skill = txtSkills.Text;
                await HttpClientHelper<Question_LearninggoalViewModel>.HttpClientPostAsync(Question_Pre_Knowledge_Skill, "QuestionPreKnowledge");
        }
        /// <summary>
        /// get all question and filter if there are master question, then fill then in masterQuestions list.
        /// </summary>
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
        /// called to update the thema of the question
        /// </summary>
        public async void postThemaIdWithQuestionId()
        {
            Thread.Sleep(1);
            List<QuestionViewModel> Questions = await HttpClientHelper<QuestionViewModel>.HttpClientGetAsync("Question");
            if (Questions.Count > 0)
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
        /// get all thamas and fill them in the thema combobox
        /// </summary>
        private async void getAllThemas()
        {
            List<Content_Thema_ViewModel> themas = await HttpClientHelper<Content_Thema_ViewModel>.HttpClientGetAsync("Theme");
            comboThema.ItemsSource = themas;
        }
        /// <summary>
        /// here we get the ContentThema by question add, and 
        /// we add the value of the item to the public Question_Content_Theme object so we can show it
        /// in update dialog to be updated
        /// </summary>
        private async void getQuestionContentThemaById()
        {
            Question_Content_Theme_List = await HttpClientHelper<Question_Content_ThemeViewModel>.HttpClientGetOneByIdAsync(question.Id, "QuestionThema");
            foreach (var item in Question_Content_Theme_List)
            {
                Question_Content_Theme = item;
            }
        }
        /// <summary>
        /// here we get the preknowledge skill by question add, and 
        /// we add the value of the item to the public Question_Pre_Knowledge_Skill object so we can show it
        /// in update dialog to be updated
        /// </summary>
        private async void getQuestionPreKnowledgeSkillByQuestionId()
        {
            Question_Pre_Knowledge_Skill_List = await HttpClientHelper<Question_Pre_Knowledge_SkillViewModel>.HttpClientGetOneByIdAsync(question.Id, "QuestionPreKnowledge");
            foreach (var item in Question_Pre_Knowledge_Skill_List)
            {
                Question_Pre_Knowledge_Skill = item;
            }
        }

        private async void getQuestionLearningGoalByQuestionId()
        {
            Question_Learninggoal_List = await HttpClientHelper<Question_LearninggoalViewModel>.HttpClientGetOneByIdAsync(question.Id, "QuestionLearningGoal");
            foreach (var item in Question_Learninggoal_List)
            {
                Question_Learninggoal = item;
            }
        }

        /// <summary>
        /// get all question formulation types and fill it in the combobox
        /// </summary>
        public async void Get_Question_Formulation_TypeAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Question_Formulation_Type_TranslationViewModel> questionTypes = await HttpClientHelper<Question_Formulation_Type_TranslationViewModel>.GetItemsTranslatedBySelectedLanguageId("QuestionFormulationType", Convert.ToInt32(config.AppSettings.Settings["languageId"].Value));
            questionFormulationTypeCombo.ItemsSource = questionTypes;
        }

        /// <summary>
        /// here we get all languages and fill it in languages combobox 
        /// </summary>
        public async void GetLanguageAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Translation_LanguageViewModel> language = services.service.GetLanguageTranslatedBySelectedLanguageId(Convert.ToInt32(config.AppSettings.Settings["languageId"].Value)).Result;
            instructionLanguageCombo.ItemsSource = language;
            userLanguageCombo.ItemsSource = language;
        }
        /// <summary>
        /// here we get all the model levels and fill it in modellevel combo box 
        /// </summary>
        public async void GetOfficeApplicationAsync()
        {
            List<Office_ApplicationViewModel> officeApplication = await HttpClientHelper<Office_ApplicationViewModel>.HttpClientGetAsync("OfficeApplication");
            officeApplicationCombo.ItemsSource = officeApplication;
        }
        /// <summary>
        /// here we get all the model levels and fill it in modellevel combo box 
        /// </summary>
        public async void Get_Model_LevelAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Didactical_Model_Level_TranslationViewModel> modelLevel = await HttpClientHelper<Didactical_Model_Level_TranslationViewModel>.GetItemsTranslatedBySelectedLanguageId("DidacticalModelLevel", Convert.ToInt32(config.AppSettings.Settings["languageId"].Value));
            comboModelLevel.ItemsSource = modelLevel;
        }

        /// <summary>
        /// here we fill all info of the question that needed to be updated in the required fields
        /// </summary>
        private void fillQuestionInfo()
        {
            questionTypeCombo.Text = question.QuestionTypeName;
            userLanguageCombo.Text = question.UserInterfaceLanguageName;
            questionFormulationTypeCombo.Text = question.Question_Formulation_TypeName;
            officeApplicationCombo.Text = question.OfficeApplicationName;
            instructionLanguageCombo.Text = question.InstructionLanguageName;
            comboThema.SelectedValue = Question_Content_Theme.Content_ThemeId;
            comboModelLevel.SelectedValue = Question_Learninggoal.Didactical_Model_LevelId;
            if (Question_Learninggoal.Is_Measurable == true)
            {
                isMesurableCheckBox.IsChecked = true;
            }
            else
            {
                isMesurableCheckBox.IsChecked = false;

            }
            txtLearningGoal.Text = Question_Learninggoal.Learninggoal;
            txtSkills.Text = Question_Pre_Knowledge_Skill.Skill;
            titleTxt.Text = question.Title;
            noteTxt.Text = question.Notes;
            versionNrTxt.Text = question.Version_Number.ToString();
            questionTxt.Text = question.QuestionText;
            if (question.Is_Master_Question == true)
            {
                masterQuestionCheckBox.IsChecked = true;
                masterQuestionCombo.IsEnabled = false;
            }
            else
            {
                masterQuestionCheckBox.IsChecked = false;
                masterQuestionCombo.Text = question.Title;

            }
        }
        private void Close_Dialog(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// update the exist question when update button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Question(object sender, RoutedEventArgs e)
        {
            QuestionViewModel questionToUpdate = new QuestionViewModel();
            questionToUpdate.Id = question.Id;
            var Question_Type = (QuestionType_TranslationViewModel)questionTypeCombo.SelectedItem;
            questionToUpdate.Question_TypeId = Question_Type.QuestionTypeId;
            var Question_Formulation_Type = (Question_Formulation_Type_TranslationViewModel)questionFormulationTypeCombo.SelectedItem;
            questionToUpdate.Question_Formulation_TypeId = Question_Formulation_Type.Question_Formulation_TypeId;
            var Office_Application = (Office_ApplicationViewModel)officeApplicationCombo.SelectedItem;
            questionToUpdate.Office_ApplicationId = Office_Application.Id;
            questionToUpdate.Instruction_LanguageId = (int)instructionLanguageCombo.SelectedValue;
            questionToUpdate.UserInterface_LanguageId = (int)userLanguageCombo.SelectedValue;
            if (masterQuestionCheckBox.IsChecked == true)
            {
                questionToUpdate.Is_Master_Question = true;
                questionToUpdate.Master_QuestionId = null;
            }
            else
            {
                questionToUpdate.Is_Master_Question = false;
            }
            questionToUpdate.Title = titleTxt.Text;
            questionToUpdate.Notes = noteTxt.Text;
            questionToUpdate.Version_Number = Convert.ToInt32(versionNrTxt.Text);
            questionToUpdate.QuestionText = questionTxt.Text;
            questionToUpdate.ReplicationKey = question.ReplicationKey;
            HttpClientHelper<QuestionViewModel>.HttpClientPostAsync(questionToUpdate, "Question");
            Thread.Sleep(100);
            _questionsUserControl.GetQuestionsAsync();
            updateQuestionContentThema();
            updateQuestionLearningGoal();
            updateQuestionPreKnowledge();
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
        private async void updateQuestionContentThema()
        {
            Question_Content_ThemeViewModel question_Content_Theme = new Question_Content_ThemeViewModel();
            var question_Thema = (Content_Thema_ViewModel)comboThema.SelectedItem;
            question_Content_Theme.Id = Question_Content_Theme.Id;
            question_Content_Theme.Content_ThemeId = question_Thema.Id;
            question_Content_Theme.QuestionId = question.Id;
            await HttpClientHelper<Question_Content_ThemeViewModel>.HttpClientPostAsync(question_Content_Theme, "QuestionThema");
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
