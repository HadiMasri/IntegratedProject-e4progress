using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using E4Progress.DAL.Entities;
using E4Progress.UI.Shared;
using System.Configuration;
using System.Threading;
using E4Progress.Shared.ViewModels;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for NewCourseDialog.xaml
    /// </summary>
    public partial class NewCourseDialog : Window
    {
        private readonly CoursesUserControl _coursesUserControl;
        public NewCourseDialog(CoursesUserControl coursesUserControl)
        {
            InitializeComponent();
            _coursesUserControl = coursesUserControl;
            GetOfficeApplicationAsync();
            GetLanguageAsync();
            fillImages();
        }


        /// <summary>
        /// this methode called when we want to upload new file (Image)
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
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(imageArray);
                bi.EndInit();
                image.Source = bi;
                imagetxt.Clear();
                imagetxt.Text = Convert.ToBase64String(imageArray);
                imageCombo.Text = "";
            }
        }

        /// <summary>
        /// fill images combobox with names of the photos 
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
        /// create new course in data base when all fields are filled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveCourse_Click(object sender, RoutedEventArgs e)
        {
            if (validation())
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var officeApplication = (Office_Application)OfficeAppCombo.SelectedItem;
           
            Course course = new Course();
            course.Name = CursusNametxt.Text;
            course.Icon = imagetxt.Text;
            course.Office_ApplicationId = officeApplication.Id;
            course.Instruction_LanguageId = (int)InstructieTaalCombo.SelectedValue;
            course.UserInterface_LanguageId = (int)GebruikerTaalCombo.SelectedValue;
            course.Created_By = Convert.ToInt32(config.AppSettings.Settings["id"].Value);
            course.ReplicationKey = GUIDtxt.Text;
            if (course.ReplicationKey == "")
            {
                Guid guid = Guid.NewGuid();
                course.ReplicationKey = guid.ToString();
            }
       
                course.Created_On = DateTime.Now;
                HttpClientHelper<Course>.HttpClientPostAsync(course, "Course");
                Thread.Sleep(100);
                _coursesUserControl.GetCoursesAsync();
                this.Close();
            }
            else
            {
                MessageBox.Show("An error has been occurred while creating new course");
            }
           
        }

        private bool validation()
        {
            bool valid = true;
            if (CursusNametxt.Text == "")
            {
                 valid = false;
            }
            if (OfficeAppCombo.SelectedItem == null)
            {
                 valid = false;
            }
            if (GebruikerTaalCombo.SelectedItem == null)
            {
                valid = false;
            }
            if (InstructieTaalCombo.SelectedItem == null)
            {
                valid = false;
            }
            if (imageCombo.SelectedItem == null)
            {
                valid = false;
            }
            return valid;
        }
        /// <summary>
        /// get all office application from database and fill it in combobox of office application
        /// </summary>
        public async void GetOfficeApplicationAsync()
        {
            List<Office_Application> officeApplication= await HttpClientHelper<Office_Application>.HttpClientGetAsync("OfficeApplication");
            OfficeAppCombo.ItemsSource = officeApplication;
        }
        /// <summary>
        /// get all languages from database and fill it in combobox of languages
        /// </summary>
        public async void GetLanguageAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            List<Translation_LanguageViewModel> language = services.service.GetLanguageTranslatedBySelectedLanguageId(Convert.ToInt32(config.AppSettings.Settings["languageId"].Value)).Result;
            InstructieTaalCombo.ItemsSource = language;
            GebruikerTaalCombo.ItemsSource = language;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// when select any item from the combobox of images, then show the image of office application in create dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtFileName.Clear();
            string selectedIcon = (string)imageCombo.SelectedItem;
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
        /// <summary>
        /// Lettters validation
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
