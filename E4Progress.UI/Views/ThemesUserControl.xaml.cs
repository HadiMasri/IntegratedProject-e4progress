using E4Progress.Shared.ViewModels;
using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;
using System.Linq;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for ThemesUserControl.xaml
    /// </summary>
    public partial class ThemesUserControl : UserControl
    {
        public List<ThemesUserControlViewModel> Themes { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
        public List<Question_Content_ThemeViewModel> QuestionsTheme { get; set; }

        int selectedId = -1;

        public ThemesUserControl()
        {
            InitializeComponent();
            GetThemes();
            GetQuestions();
        }

        public async void GetThemes()
        {
            Themes = await HttpClientHelper<ThemesUserControlViewModel>.HttpClientGetAsync("Theme");
            if (Themes != null)
            {
                Themes.Reverse();
            }
            lbTodoList.ItemsSource = Themes;
        }

        public async void GetQuestions()
        {
            Questions = await HttpClientHelper<QuestionViewModel>.HttpClientGetAsync("Question");
            if (Questions != null)
            {
                Questions.Reverse();
            }
            vragenlijst.ItemsSource = Questions;
        }

        public async void GetQuestionThemes()
        {
            QuestionsTheme = await HttpClientHelper<Question_Content_ThemeViewModel>.HttpClientGetAsync("QuestionThema");
            if (QuestionsTheme != null)
            {
                QuestionsTheme.Reverse();
            }

            var questionThemeQuery = from question in Questions
                                     join questionTheme in QuestionsTheme on question.Id equals questionTheme.QuestionId
                                     where questionTheme.Content_ThemeId == selectedId
                                     select new { question.Title };
            vragenlijst.ItemsSource = questionThemeQuery;

        }

        public async void PostTheme(ThemesUserControlViewModel theme)
        {
            var query = Themes.Find(item => item.Name == theme.Name);
            if(ThemeTextBox.Text == "")
            {
                MessageBox.Show("Cannot Leave the textbox empty");
            } else if (ThemeTextBox.Text.Length > 40 )
            {
                MessageBox.Show("Cannot be more than 40 characters");
            }

          else if(query == null)
            {
                await HttpClientHelper<ThemesUserControlViewModel>.HttpClientPostAsync(theme, "Theme");

                MessageBox.Show("Added/Edited Theme " + theme.Name);
            } else
            {
                MessageBox.Show("Theme " + theme.Name + " already exists");
            }
      
            GetThemes();

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AddTheme_Click(object sender, RoutedEventArgs e)
        {
            ThemesUserControlViewModel theme = new ThemesUserControlViewModel();
            theme.Name = ThemeTextBox.Text;
            PostTheme(theme);
            DialogHost.IsOpen = false;
        }

        

        private void EditTheme_Click(object sender, RoutedEventArgs e)
        {
            ThemesUserControlViewModel theme = new ThemesUserControlViewModel();
            ThemesUserControlViewModel selectedTheme = (ThemesUserControlViewModel)lbTodoList.SelectedItem;
            theme.Id = selectedTheme.Id;
            theme.Name = ThemeTextBox.Text;
            PostTheme(theme);
            DialogHost.IsOpen = false;

        }

        private void OpenEdit(object sender, RoutedEventArgs e)
        {

            if(lbTodoList.SelectedItem == null)
            {
                MessageBox.Show("Select A Theme First");
              
            } else {
                ThemesUserControlViewModel selectedTheme = (ThemesUserControlViewModel)lbTodoList.SelectedItem;
                ThemeTextBox.Text = selectedTheme.Name;
                DialogHost.IsOpen = true;
                addBtn.Visibility = Visibility.Hidden;
                editBtn.Visibility = Visibility.Visible;
            }
        }

        private void OpenAdd(object sender, RoutedEventArgs e)

        {
            ThemeTextBox.Clear();
            DialogHost.IsOpen = true;
            addBtn.Visibility = Visibility.Visible;
            editBtn.Visibility = Visibility.Hidden;
            
        }
        private async void RemoveTheme_Click(object sender, RoutedEventArgs e)
        {
            Button cmd = (Button)sender;
            if (cmd.DataContext is ThemesUserControlViewModel)

            {
                ThemesUserControlViewModel theme = (ThemesUserControlViewModel)cmd.DataContext;
               await HttpClientHelper<ThemesUserControlViewModel>.HttpClientDeleteAsync(theme.Id, "Theme");
                System.Threading.Thread.Sleep(200);
                GetThemes();
            };    
        }

        private void lbTodoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetQuestionThemes();
        }
    }
}
