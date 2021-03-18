using E4Progress.DAL.Entities;
using E4Progress.UI.Shared;
using Microsoft.Win32;
using System;
using CourseViewModel = E4Progress.Shared.ViewModels.CourseViewModel;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using E4Progress.Shared.ViewModels;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Threading;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for UpdateCourseDialog.xaml
    /// </summary>
    public partial class UpdateCourseDialog : Window
    {
        CourseViewModel course;
        private readonly CoursesUserControl _coursesUserControl;
   
        public UpdateCourseDialog(CourseViewModel course, CoursesUserControl coursesUserControl)
        {
            InitializeComponent();
            this.course = course;
            _coursesUserControl = coursesUserControl;
            GetOfficeApplicationAsync();
            GetLanguageAsync();
            fillCourseInfo();
            fillImages();
        }

        /// <summary>
        /// fill the fields with the data of the selected course that needs to be updated.
        /// </summary>
        public void fillCourseInfo()
        {
            CursusNametxt.Text = course.Name;
            OfficeAppCombo.Text = course.Office_ApplicationName;
            InstructieTaalCombo.Text = course.Instruction_LanguageName;
            GebruikerTaalCombo.Text = course.UserInterface_LanguageName;
            GUIDtxt.Text = course.ReplicationKey;
            if (course.Icon != "")
            {
                
                byte[] binaryData = Convert.FromBase64String(course.Icon);
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(binaryData);
                bi.EndInit();
                image.Source = bi;
                imageCombo.Text = "";
            }
           
        }
        /// <summary>
        /// fill images names of office application in the combobox
        /// </summary>
        public void fillImages()
        {
            imageCombo.Items.Add("Access");
            imageCombo.Items.Add("Excel");
            imageCombo.Items.Add("OneNote");
            imageCombo.Items.Add("Word");
            imageCombo.Items.Add("PowerPoint");
            imageCombo.Items.Add("Outlook");
        }
        /// <summary>
        /// get all office application and fill them in the combobox
        /// </summary>
        public async void GetOfficeApplicationAsync()
        {
            List<Office_Application> officeApplication = await HttpClientHelper<Office_Application>.HttpClientGetAsync("OfficeApplication");
            OfficeAppCombo.ItemsSource = officeApplication;
        }
        /// <summary>
        /// get all languages and fill them in the combobox
        /// </summary>
        public async void GetLanguageAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Translation_LanguageViewModel> language = services.service.GetLanguageTranslatedBySelectedLanguageId(Convert.ToInt32( config.AppSettings.Settings["languageId"].Value)).Result;
            InstructieTaalCombo.ItemsSource = language;
            GebruikerTaalCombo.ItemsSource = language;
        }

        /// <summary>
        /// when update button clicked, update the course with the new data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveCourse_Click(object sender, RoutedEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var officeApplication = (Office_Application)OfficeAppCombo.SelectedItem;
         
            Course courseToUpdate = new Course();
            courseToUpdate.Id = course.Id;
            courseToUpdate.Name = CursusNametxt.Text;
            courseToUpdate.Icon = imagetxt.Text;
            courseToUpdate.Office_ApplicationId = officeApplication.Id;
            courseToUpdate.Created_By = Convert.ToInt32(config.AppSettings.Settings["id"].Value);
            courseToUpdate.Instruction_LanguageId = (int)InstructieTaalCombo.SelectedValue;
            courseToUpdate.UserInterface_LanguageId = (int)GebruikerTaalCombo.SelectedValue;
            courseToUpdate.ReplicationKey = GUIDtxt.Text;
            courseToUpdate.Created_On = DateTime.Now;
            HttpClientHelper<Course>.HttpClientPostAsync(courseToUpdate, "Course");
            Thread.Sleep(100);
            this.Close();
            _coursesUserControl.GetCoursesAsync();
        }

        /// <summary>
        /// when file (image) needs to be uploaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFileUpload_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg";
            if (fileDialog.ShowDialog() == true)
            {
                var fileName = System.IO.Path.GetFileName(fileDialog.FileName);
                txtFileName.Text = fileName;
                byte[] imageArray = System.IO.File.ReadAllBytes(fileDialog.FileName);
                imagetxt.Clear();
                imagetxt.Text = Convert.ToBase64String(imageArray);
            }
        }

        /// <summary>
        /// show the image of the selected item of office application images in the update dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboImage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedIcon = (string)imageCombo.SelectedItem;
            txtFileName.Clear();
            if (selectedIcon == "Excel")
            {
                getImageName("Excel.png");
                
            }
            else if (selectedIcon == "Access")
            {
                getImageName("Access.png");
            }
            else if (selectedIcon == "Word")
            {
                getImageName("word.png");
            }
            else if (selectedIcon == "OneNote")
            {
                getImageName("OneNote.png");
            }
            else if (selectedIcon == "Outlook")
            {
                getImageName("Outlook.png");
            }
            else if (selectedIcon == "PowerPoint")
            {
                getImageName("PowerPoint.png");
            }
        }
        public void getImageName(string imageName)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes("../../../Assets/" + imageName);
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(imageArray);
            bi.EndInit();
            image.Source = bi;
            imagetxt.Clear();
            imagetxt.Text = Convert.ToBase64String(imageArray);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
