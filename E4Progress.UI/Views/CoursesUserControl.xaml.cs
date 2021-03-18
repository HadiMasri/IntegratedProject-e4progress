using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using E4Progress.Shared.ViewModels;
using E4Progress.UI.Shared;
using E4Progress.UI.ViewModels;
using CourseViewModel = E4Progress.Shared.ViewModels.CourseViewModel;
using System.Configuration;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Linq;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for CoursesUserControl.xaml
    /// </summary>
    public partial class CoursesUserControl : UserControl
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        CoursesUserControlViewModel coursesUserControlViewModel = new CoursesUserControlViewModel();
        List<CourseViewModel> CoursesWithTranlation = new List<CourseViewModel>();
        List<Course_ModuleViewModel> AllModules;
        List<Course_Module_TopicViewModel> AllTopics;
        List<Course_ModuleViewModel> ModulesCount = new List<Course_ModuleViewModel>();
        List<Course_Module_TopicViewModel> TopicsCount = new List<Course_Module_TopicViewModel>();

        int pageIndex = 1;
        private int numberOfRowsPerPage;
        private enum PagingMode { First = 1, Next = 2, Previous = 3, Last = 4, PageCountChange = 5 };
        List<CourseViewModel> CourseList = new List<CourseViewModel>();
        public CoursesUserControl()
        {
            InitializeComponent();
            GetModules();
            GetTopics();
            GetCoursesAsync();
            GetOfficeApplicationAsync();
            GetLanguageAsync();
            FillRowsCombo();
        }
        /// <summary>
        /// with this method we get all courses from data base and fill it in courses datagrid
        /// </summary>
        public async void GetCoursesAsync()
        {
            CoursesDataGrid.ItemsSource = null;
            CourseList.Clear();
            CoursesWithTranlation.Clear();
            List<CourseViewModel> Courses = await HttpClientHelper<CourseViewModel>.HttpClientGetAsync("Course");

            Courses.Reverse();


            foreach (var item in Courses)
            {
                ModulesCount.Clear();
                TopicsCount.Clear();
                  var Instruction_Language_Name = item.Instruction_Language.Native_Name;
                var UserInterface_Language_Name = item.UserInterface_Language.Native_Name;
                switch (Instruction_Language_Name)
                {
                    case "English":
                        Instruction_Language_Name = coursesUserControlViewModel.English;
                        break;
                    case "Dutch":
                        Instruction_Language_Name = coursesUserControlViewModel.Dutch;
                        break;
                    case "French":
                        Instruction_Language_Name = coursesUserControlViewModel.French;
                        break;

                    case "Engels":
                        Instruction_Language_Name = coursesUserControlViewModel.English;
                        break;
                    case "Nederlands":
                        Instruction_Language_Name = coursesUserControlViewModel.Dutch;
                        break;
                    case "Frans":
                        Instruction_Language_Name = coursesUserControlViewModel.French;
                        break;

                    case "Anglais":
                        Instruction_Language_Name = coursesUserControlViewModel.English;
                        break;
                    case "Néerlandais":
                        Instruction_Language_Name = coursesUserControlViewModel.Dutch;
                        break;
                    case "Français":
                        Instruction_Language_Name = coursesUserControlViewModel.French;
                        break;
                    default:
                        break;
                }
                switch (UserInterface_Language_Name)
                {
                    case "English":
                        UserInterface_Language_Name = coursesUserControlViewModel.English;
                        break;
                    case "Dutch":
                        UserInterface_Language_Name = coursesUserControlViewModel.Dutch;
                        break;
                    case "French":
                        UserInterface_Language_Name = coursesUserControlViewModel.French;
                        break;

                    case "Engels":
                        UserInterface_Language_Name = coursesUserControlViewModel.English;
                        break;
                    case "Nederlands":
                        UserInterface_Language_Name = coursesUserControlViewModel.Dutch;
                        break;
                    case "Frans":
                        UserInterface_Language_Name = coursesUserControlViewModel.French;
                        break;

                    case "Anglais":
                        UserInterface_Language_Name = coursesUserControlViewModel.English;
                        break;
                    case "Néerlandais":
                        UserInterface_Language_Name = coursesUserControlViewModel.Dutch;
                        break;
                    case "Français":
                        UserInterface_Language_Name = coursesUserControlViewModel.French;
                        break;
                    default:
                        break;
                }
                CoursesWithTranlation.Add(new CourseViewModel
                {
                    Id = item.Id,
                    Office_Application = item.Office_Application,
                    Office_ApplicationName = item.Office_Application.Name,
                    Office_Application_Id = item.Office_Application_Id,
                    Name = item.Name,
                    ReplicationKey = item.ReplicationKey,
                    Instruction_Language = item.Instruction_Language,
                    Instruction_LanguageName = Instruction_Language_Name,
                    Instruction_LanguageId = item.Instruction_LanguageId,
                    UserInterface_Language = item.UserInterface_Language,
                    UserInterface_LanguageName = UserInterface_Language_Name,
                    UserInterface_LanguageId = item.UserInterface_LanguageId,
                    Icon = item.Icon
                });

                foreach (var module in AllModules)
                {
                    if (module.CourseId == item.Id)
                    {
                        ModulesCount.Add(module);
                        foreach (var topic in AllTopics)
                        {
                            if (topic.Course_ModuleId == module.Id)
                            {
                                TopicsCount.Add(topic);
                            }
                        }
                    }
                    
                }
                CourseList.Add(new CourseViewModel
                {
                    Id = item.Id,
                    Office_ApplicationName = item.Office_Application.Name,
                    Office_Application_Id = item.Office_Application_Id,
                    Name = item.Name,
                    ReplicationKey = item.ReplicationKey,
                    Instruction_LanguageName = Instruction_Language_Name,
                    Instruction_LanguageId = item.Instruction_LanguageId,
                    UserInterface_LanguageName = UserInterface_Language_Name,
                    UserInterface_LanguageId = item.UserInterface_LanguageId,
                    Icon = item.Icon,
                    ModuleNumbers = ModulesCount.Count,
                    TopicsNumbers = TopicsCount.Count
                });
            }
            CoursesDataGrid.ItemsSource = CourseList.Take(numberOfRowsPerPage);
            int count = CourseList.Take(numberOfRowsPerPage).Count();
            TxtPageInfo.Text = count + " / " + CourseList.Count;

        }
        /// <summary>
        /// gett all modules and fill it in Allmodules list
        /// </summary>
        public async void GetModules()
        {
            AllModules = await HttpClientHelper<Course_ModuleViewModel>.HttpClientGetAsync("Module");
        }
        /// <summary>
        /// gett all Topics and fill it in AllTopics list
        /// </summary>
        public async void GetTopics()
        {
            AllTopics = await HttpClientHelper<Course_Module_TopicViewModel>.HttpClientGetAsync("Topic");
        }
        /// <summary>
        /// Fill combo box with number of rows per page
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
        /// show new course dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemNew_Click(object sender, RoutedEventArgs e)
        {
            NewCourseDialog newCourseView = new NewCourseDialog(this);
            newCourseView.ShowDialog();
        }
        /// <summary>
        /// get all office application from data base and fill it in office applications combobox
        /// </summary>
        public async void GetOfficeApplicationAsync()
        {
            List<Office_ApplicationViewModel> officeApplication = await HttpClientHelper<Office_ApplicationViewModel>.HttpClientGetAsync("OfficeApplication");
            OfficeAppFilterCombo.ItemsSource = officeApplication;
        }
        /// <summary>
        /// get all languages from data base and fill it in languages comboboxes
        /// </summary>
        public void GetLanguageAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Translation_LanguageViewModel> language = services.service.GetLanguageTranslatedBySelectedLanguageId(Convert.ToInt32(config.AppSettings.Settings["languageId"].Value)).Result;
            InstructieTaalFilterCombo.ItemsSource = language;
            GebruikerTaalFilterCombo.ItemsSource = language;
        }

        /// <summary>
        /// for datagrid data filter
        /// </summary>
        private void FilterData()
        {
            List<CourseViewModel> filteredCoursesViews = CoursesWithTranlation;
            Office_ApplicationViewModel app = (Office_ApplicationViewModel)OfficeAppFilterCombo.SelectedItem;
            Translation_LanguageViewModel instructionLanguage = (Translation_LanguageViewModel)InstructieTaalFilterCombo.SelectedItem;
            Translation_LanguageViewModel uiLanguage = (Translation_LanguageViewModel)GebruikerTaalFilterCombo.SelectedItem;
            string courseName = CursusNameFiltertxt.Text;

                if (app != null)
                filteredCoursesViews = filteredCoursesViews.FindAll(course => course.Office_ApplicationName == app.Name);

            if (!string.IsNullOrEmpty(courseName))
                filteredCoursesViews = filteredCoursesViews.FindAll(course => course.Name.ToLower().Contains(courseName.ToLower()));

            if (instructionLanguage != null)
                filteredCoursesViews = filteredCoursesViews.FindAll(course => course.Instruction_LanguageName == instructionLanguage.Translation);

            if (uiLanguage != null)
                filteredCoursesViews = filteredCoursesViews.FindAll(course => course.UserInterface_LanguageName == uiLanguage.Translation);
            CoursesDataGrid.Items.Refresh();
            CoursesDataGrid.ItemsSource = filteredCoursesViews.Take(numberOfRowsPerPage);
            int count = filteredCoursesViews.Take(numberOfRowsPerPage).Count();
            TxtPageInfo.Text = count + " / " + filteredCoursesViews.Count;
        }
        /// <summary>
        /// when the text change, we call Filter data methode to get the filtered data 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CursusNameFiltertxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterData();
        }
        /// <summary>
        /// when the selection in combo box change, we call Filter data methode to get the filtered data 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OfficeAppCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();

        }
        /// <summary>
        /// when the selection in combo box change, we call Filter data methode to get the filtered data 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GebruikerTaalFilterCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();

        }
        /// <summary>
        /// when the selection in combo box change, we call Filter data methode to get the filtered data 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstructieTaalFilterCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterData();
        }

        /// <summary>
        /// show update course dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Course(object sender, RoutedEventArgs e)
        {
            var course = (CourseViewModel)CoursesDataGrid.SelectedItem;

            // Activate click method only if an item is selected
            if (course != null)
            {
                UpdateCourseDialog updateCourse = new UpdateCourseDialog(course, this);
                updateCourse.Show();
            }
            
        }

        private void itemLayout_Click(object sender, RoutedEventArgs e)
        {
            var course = (CourseViewModel)CoursesDataGrid.SelectedItem;

            // Activate click method only if an item is selected
            if (course != null)
            {
                LayoutUserControl courseLayout = new LayoutUserControl(course, this);
                //CoursePanel.Children.Clear();
                //CoursePanel.Children.Add(courseLayout);
                CourseMainView.Visibility = Visibility.Hidden;
                PaginationGrid.Visibility = Visibility.Hidden;
                FilterView.Visibility = Visibility.Hidden;
                LayoutView.Visibility = Visibility.Visible;
                LayoutView.Children.Add(courseLayout);
            }
            
        }

        /// <summary>
        /// reset the filter fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Filter(object sender, RoutedEventArgs e)
        {
            GebruikerTaalFilterCombo.Text = "";
            InstructieTaalFilterCombo.Text = "";
            OfficeAppFilterCombo.Text = "";
            CursusNameFiltertxt.Text = "";
        }

        /// <summary>
        /// validation method for letters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lettersValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]");
            e.Handled = regex.IsMatch(e.Text);
        }


        /// <summary>
        /// Navigation method to carryout the pagination function
        /// </summary>
        /// <param name="mode"></param>
        private void Navigate(int mode)
        {
            int count;
            switch (mode)
            {
                case (int)PagingMode.Next:
                    BtnPrev.IsEnabled = true;
                    BtnFirst.IsEnabled = true;
                    if (CourseList.Count >= (pageIndex * numberOfRowsPerPage))
                    {
                        if (CourseList.Skip(pageIndex *
                        numberOfRowsPerPage).Take(numberOfRowsPerPage).Count() == 0)
                        {
                            CoursesDataGrid.ItemsSource = null;
                            CoursesDataGrid.ItemsSource = CourseList.Skip((pageIndex *
                            numberOfRowsPerPage) - numberOfRowsPerPage).Take(numberOfRowsPerPage);
                            count = (pageIndex * numberOfRowsPerPage) +
                            (CourseList.Skip(pageIndex *
                            numberOfRowsPerPage).Take(numberOfRowsPerPage)).Count();
                        }
                        else
                        {
                            CoursesDataGrid.ItemsSource = null;
                            CoursesDataGrid.ItemsSource = CourseList.Skip(pageIndex *
                            numberOfRowsPerPage).Take(numberOfRowsPerPage);
                            count = (pageIndex * numberOfRowsPerPage) +
                            (CourseList.Skip(pageIndex *
                            numberOfRowsPerPage).Take(numberOfRowsPerPage)).Count();
                            pageIndex++;
                        }

                        TxtPageInfo.Text = count + " / " + CourseList.Count;
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
                        CoursesDataGrid.ItemsSource = null;
                        if (pageIndex == 1)
                        {
                            CoursesDataGrid.ItemsSource = CourseList.Take(numberOfRowsPerPage);
                            count = CourseList.Take(numberOfRowsPerPage).Count();
                            TxtPageInfo.Text = count + " / " + CourseList.Count;
                        }
                        else
                        {
                            CoursesDataGrid.ItemsSource = CourseList.Skip
                            (pageIndex * numberOfRowsPerPage).Take(numberOfRowsPerPage);
                            count = Math.Min(pageIndex * numberOfRowsPerPage, CourseList.Count);
                            TxtPageInfo.Text = count + " / " + CourseList.Count;
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
                    pageIndex = (CourseList.Count / numberOfRowsPerPage);
                    Navigate((int)PagingMode.Next);
                    break;

                case (int)PagingMode.PageCountChange:
                    pageIndex = 1;
                    numberOfRowsPerPage = Convert.ToInt32(CbNumberOfRows.SelectedItem);
                    CoursesDataGrid.ItemsSource = null;
                    CoursesDataGrid.ItemsSource = CourseList.Take(numberOfRowsPerPage);
                    count = (CourseList.Take(numberOfRowsPerPage)).Count();
                    TxtPageInfo.Text = count + " / " + CourseList.Count;
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
