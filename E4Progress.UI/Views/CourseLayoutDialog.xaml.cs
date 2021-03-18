using E4Progress.Shared.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for CourseLayoutDialog.xaml
    /// </summary>
    public partial class CourseLayoutDialog : Window
    {
        CourseViewModel _course;
        private readonly CoursesUserControl _coursesUserControl;

        public CourseLayoutDialog(CourseViewModel course, CoursesUserControl coursesUserControl)
        {
            InitializeComponent();

            this._course = course;
            _coursesUserControl = coursesUserControl;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Get selected course
            var item = new TreeViewItem()
            {
                // Set parent tree header
                Header = _course.Name,
                Tag = _course
            };

            // Add a dummy item
            //item.Items.Add(null);

            // Listen out for item being expanded
            item.Expanded += Course_Expanded;

            // Add treeview to main treeview
            CourseLayout.Items.Add(item);

            var subItem = new TreeViewItem()
            {
                Header = _course.Office_Application
            };

            var subItem1 = new TreeViewItem()
            {
                Header = _course.ReplicationKey
            };

            var subSubItem = new TreeViewItem()
            {
                Header = _course.Instruction_Language
            };

            subItem.Items.Add(subSubItem);

            item.Items.Add(subItem);
            item.Items.Add(subItem1);

        }

        private void Course_Expanded(object sender, RoutedEventArgs e)
        {
            var item = (TreeViewItem)sender;

            // if the item only contains the dummy data
            if (item.Items.Count != 1 || item.Items[0] != null) return;

            // Clear dummy data
            item.Items.Clear();

            // Get module name
            var moduleName = item.Tag;

            // Create blank list of modules
            List<Course_ModuleViewModel> modules = (List<Course_ModuleViewModel>)_course.Course_Modules;

            //modules.ForEach(module =>
            //{
            //    var subItem = new TreeViewItem()
            //    {
            //        Header = module
            //    };
            //});
            //foreach (var module in modules)
            //{
                var subItem = new TreeViewItem()
                {
                    Header = _course.Office_Application,
                    Tag = _course.ReplicationKey
                };

                // Add dummy item to expand
                //subItem.Items.Add(null);

                // Handle expanding
                subItem.Expanded += Course_Expanded;

                // Add this item to the parent
                item.Items.Add(subItem);
            //}
        }
    }
}
