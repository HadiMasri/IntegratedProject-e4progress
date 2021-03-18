using E4Progress.Shared.ViewModels;
using E4Progress.UI.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for LayoutUserControl.xaml
    /// </summary>

    public partial class LayoutUserControl : UserControl
    {
        Point _lastMouseDown;
        TreeViewItem draggedItem, _target;
        public TreeViewItem CourseItem;
        public TreeViewItem ModuleItem;
        public TreeViewItem TopicItem;
        public TreeViewItem ElementItem;
        CourseViewModel _course;
        private readonly CoursesUserControl _coursesUserControl;
        List<Course_ModuleViewModel> Modules;
        List<Course_Module_TopicViewModel> Topics;
        List<Course_Module_Topic_ElementViewModel> Elements;


        public LayoutUserControl(CourseViewModel course, CoursesUserControl coursesUserControl)
        {
            InitializeComponent();
            GetModules();
            GetTopics();
            GetElements();
            this._course = course;
            _coursesUserControl = coursesUserControl;
        }

        //Call Module Data from Api



        public void CreateTreeView()
        {

            GetModules();
            GetTopics();
            GetElements();
            CourseLayout.Items.Clear();

            CourseItem = new TreeViewItem
            {
                //Link the header(is a textblock) to the module 
                Header = _course.Name,
                Tag = _course
            };
            CourseLayout.Items.Add(CourseItem);

            #region

            //Loop through all modules
            foreach (var module in Modules)
            {
                //create a treeviewItem
                if (module.CourseId == _course.Id)
                {
                    ModuleItem = new TreeViewItem()
                    {
                        //Link the header(is a textblock) to the module 
                        Header = module.Title,
                        Tag = module

                    };
                    //add module to the right course
                    CourseItem.Items.Add(ModuleItem);
                    //Loop through all Topics
                    foreach (var topic in Topics)
                    {
                        //check if topic is in right module and add it
                        if (topic.Course_ModuleId == module.Id)
                        {
                            //create a treeviewItem for each topic
                            TopicItem = new TreeViewItem()
                            {
                                Header = topic.Title,
                                Tag = topic
                            };

                            ModuleItem.Items.Add(TopicItem);
                            //Loop through all Elements
                            foreach (var element in Elements)
                            {
                                //check if Element is in right Topic and add it
                                if (element.Course_Module_TopicId == topic.Id)
                                {
                                    //Create Treeview for each element 
                                    ElementItem = new TreeViewItem()
                                    {
                                        Header = element.Content_ElementId,
                                        Tag = element
                                    };

                                    TopicItem.Items.Add(ElementItem);


                                }

                            }
                        }
                    }
                };
            }
        }
        //Get Data From service
        public async void GetModules()
        {
            Modules = await HttpClientHelper<Course_ModuleViewModel>.HttpClientGetAsync("Module");
            if (Modules != null)
            {
                Modules = Modules.OrderBy(number => number.Sortorder).ToList();
            }

        }
        //Call Topic Data from Api
        public async void GetTopics()
        {
            Topics = await HttpClientHelper<Course_Module_TopicViewModel>.HttpClientGetAsync("Topic");
            if (Topics != null)
            {
                Topics = Topics.OrderBy(number => number.Sortorder).ToList();
            }
        }
        //Call Element Data from Api
        public async void GetElements()
        {
            Elements = await HttpClientHelper<Course_Module_Topic_ElementViewModel>.HttpClientGetAsync("Element");

            if (Elements != null)
            {
                Elements.Reverse();
            }
        }

        public async void PostModule(Course_ModuleViewModel module)
        {
                await HttpClientHelper<Course_ModuleViewModel>.HttpClientPostAsync(module, "Module");

                Thread.Sleep(10);
                _coursesUserControl.GetModules();
                CreateTreeView();

            CloseItemConfigurationMenu();

        }
        public async void PostTopic(Course_Module_TopicViewModel topic)
        {
            var query = Topics.Find(item => item.Title == topic.Title);
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Cannot Leave the textbox empty");
                return;
            }
            else if (txtTitle.Text.Length > 255)
            {
                MessageBox.Show("Cannot be more than 255 characters");
                return;
            }

            else if (query == null)
            {
                await HttpClientHelper<Course_Module_TopicViewModel>.HttpClientPostAsync(topic, "Topic");

                Thread.Sleep(10);
                _coursesUserControl.GetTopics();
                CreateTreeView();
            }
            else
            {
                MessageBox.Show("topic " + topic.Title + " already exists");
                return;
            }
            CloseItemConfigurationMenu();

        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            InputFields.Visibility = Visibility.Hidden;
            TopicTab.Visibility = Visibility.Hidden;
            ModuleTab.Visibility = Visibility.Hidden;
            ItemHeader.Visibility = Visibility.Hidden;
            CreateTreeView();
        }



        //Add A Module Below
        private void SaveModuleAbove_Click(object sender, RoutedEventArgs e)
        {

            //Opening The Module Tab Alongside the menu/form/buttons on the right side of the screen
            OpenTabModule();
            InputFields.Visibility = Visibility.Hidden;

            var query = Modules.Find(item => item.Title == txtTitle.Text && item.CourseId == _course.Id);
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Cannot Leave the textbox empty");
            }
            else if (txtTitle.Text.Length > 255)
            {
                MessageBox.Show("Cannot be more than 255 characters");
            }else if (query != null)
            {
                MessageBox.Show("Already Exists");
            } else
            {

            Course_ModuleViewModel module = new Course_ModuleViewModel();
            //Getting All The modules within the current course
            var queryModules = Modules.FindAll(module => module.CourseId == _course.Id).ToList();
            //getting the selected module within the treeview
            TreeViewItem selectedTreeItem = (TreeViewItem)CourseLayout.SelectedItem;
            //checking if the selected treeview item is a module
            if (selectedTreeItem.Tag is Course_ModuleViewModel)
            {
                //getting the data from the selected module
                Course_ModuleViewModel selected = (Course_ModuleViewModel)selectedTreeItem.Tag;
                //checking if there are already modules above the one that is selected 
                var sortOrder = selected.Sortorder - 1;
                var queryModuleAbove = queryModules.Find(module => module.Sortorder == sortOrder);

                if (queryModuleAbove != null)
                {
                    //if there are modules above get a list of them
                    var queryAllModulesAbove = queryModules.FindAll(module => module.Sortorder <= sortOrder);
                    //loop through each module and reassign them a new value {current SortOrder-1}
                    foreach (Course_ModuleViewModel moduleAbove in queryAllModulesAbove)
                    {
                        moduleAbove.Sortorder -= 1;
                        PostModule(moduleAbove);
                    }
                }
                //Setting values of new module that will come above
                module.CourseId = _course.Id;
                module.Title = txtTitle.Text;
                //order must me right above the one that is selected
                module.Sortorder = selected.Sortorder - 1;
                //checking if the course is selected instead of module
            }
            else if (selectedTreeItem.Tag is CourseViewModel)
            {
                //Order All the modules descending so that i may take the lastvalue (this so i can place the next module all the way up)
                var item = queryModules.OrderByDescending(i => i.Sortorder).LastOrDefault();
                module.CourseId = _course.Id;
                module.Title = txtTitle.Text;
                //Checking if there even is a module to begin with ,
                //if so give the value the firstmodule-1 if there is no module then give it sortordervalue of 1
                if (item != null)
                {
                    module.Sortorder = item.Sortorder - 1;
                }
                else
                {
                    module.Sortorder = 1;
                }
            }
            PostModule(module);
    
            }
        }


        //Add A Module Below
        private void SaveModuleBelow_Click(object sender, RoutedEventArgs e)
        {
            //Opening The Module Tab Alongside the menu/form/buttons on the right side of the screen
            OpenTabModule();
            InputFields.Visibility = Visibility.Hidden;

            var query = Modules.Find(item => item.Title == txtTitle.Text && item.CourseId == _course.Id);
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Cannot Leave the textbox empty");
                ItemHeader.Visibility = Visibility.Hidden;
            }
            else if (txtTitle.Text.Length > 255)
            {
                MessageBox.Show("Cannot be more than 255 characters");
                ItemHeader.Visibility = Visibility.Hidden;
            }
            else if (query != null)
            {
                MessageBox.Show("Already Exists");
                ItemHeader.Visibility = Visibility.Hidden;
            }
            else
            {
                Course_ModuleViewModel module = new Course_ModuleViewModel();
                //Getting All The modules within the current course
                var queryModules = Modules.FindAll(module => module.CourseId == _course.Id).ToList();
                //getting the selected module within the treeview
                TreeViewItem selectedTreeItem = (TreeViewItem)CourseLayout.SelectedItem;
                //checking if the selected treeview item is a module
                if (selectedTreeItem.Tag is Course_ModuleViewModel)
                {
                    //getting the data from the selected module
                    Course_ModuleViewModel selected = (Course_ModuleViewModel)selectedTreeItem.Tag;
                    //checking if there are already modules above the one that is selected 
                    var sortOrder = selected.Sortorder + 1;
                    var queryModuleAbove = queryModules.Find(module => module.Sortorder == sortOrder);

                    if (queryModuleAbove != null)
                    {
                        //if there are modules below get a list of them
                        var queryAllModulesAbove = queryModules.FindAll(module => module.Sortorder >= sortOrder);
                        //loop through each module and reassign them a new value {current SortOrder+1}
                        foreach (Course_ModuleViewModel moduleAbove in queryAllModulesAbove)
                        {
                            moduleAbove.Sortorder += 1;
                            PostModule(moduleAbove);
                        }
                    }
                    //Setting values of new module that will come above
                    module.CourseId = _course.Id;
                    module.Title = txtTitle.Text;
                    //order must me right above the one that is selected
                    module.Sortorder = selected.Sortorder + 1;
                    //checking if the course is selected instead of module
                }
                else if (selectedTreeItem.Tag is CourseViewModel)
                {
                    //Order All the modules descending so that i may take the firstValue (this so i can place the next module all the way down)
                    var item = queryModules.OrderByDescending(i => i.Sortorder).FirstOrDefault();
                    module.CourseId = _course.Id;
                    module.Title = txtTitle.Text;
                    //Checking if there even is a module to begin with ,
                    //if so give the sortorder value the lastModule+1 if there is no module then give it sortordervalue of 1
                    if (item != null)
                    {
                        module.Sortorder = item.Sortorder + 1;
                    }
                    else
                    {
                        module.Sortorder = 1;
                    }
                }
                PostModule(module);
            }
        }





        // Add A topic below
        private void SaveTopicBelow_Click(object sender, RoutedEventArgs e)
        {
            OpenTabTopic();
            InputFields.Visibility = Visibility.Hidden;

            TreeViewItem selectedTreeItem = (TreeViewItem)CourseLayout.SelectedItem;


             if (selectedTreeItem.Tag is Course_Module_TopicViewModel)
            {
                Course_Module_TopicViewModel selected = (Course_Module_TopicViewModel)selectedTreeItem.Tag;
                Course_Module_TopicViewModel topic = new Course_Module_TopicViewModel();
                topic.Course_ModuleId = selected.Course_ModuleId;
                topic.Title = tbTopic.Text;
                topic.Sortorder = selected.Sortorder + 1;
                PostTopic(topic);
            }
          else  if (selectedTreeItem.Tag is Course_ModuleViewModel)
            {
                Course_ModuleViewModel selected = (Course_ModuleViewModel)selectedTreeItem.Tag;
                Course_Module_TopicViewModel topic = new Course_Module_TopicViewModel();
                topic.Course_ModuleId = selected.Id;
                topic.Title = tbTopic.Text;
                topic.Sortorder = selected.Sortorder;
                PostTopic(topic);

            }


            /*            TopicItem = new TreeViewItem()
                        {
                            Header = topic.Title,
                            Tag = topic
                        };*/

            CourseLayout.Items.Refresh();


            CourseName.Text = "";
            ModuleName.Text = "";


            txtTitle.Text = "";
        }


        // Add A topic below
        private void SaveTopicAbove_Click(object sender, RoutedEventArgs e)
        {
            OpenTabTopic();
            InputFields.Visibility = Visibility.Hidden;

            TreeViewItem selectedTreeItem = (TreeViewItem)CourseLayout.SelectedItem;

            if (selectedTreeItem.Tag is Course_ModuleViewModel)
            {
                Course_ModuleViewModel selected = (Course_ModuleViewModel)selectedTreeItem.Tag;
                Course_Module_TopicViewModel topic = new Course_Module_TopicViewModel();
                topic.Course_ModuleId = selected.Id;
                topic.Title = tbTopic.Text;
                topic.Sortorder = selected.Sortorder;
                PostTopic(topic);

            }
            else if (selectedTreeItem.Tag is Course_Module_TopicViewModel)
            {
                Course_Module_TopicViewModel selected = (Course_Module_TopicViewModel)selectedTreeItem.Tag;
                Course_Module_TopicViewModel topic = new Course_Module_TopicViewModel();
                topic.Course_ModuleId = selected.Course_ModuleId;
                topic.Title = tbTopic.Text;
                topic.Sortorder = selected.Sortorder - 1;
                PostTopic(topic);
            }


            /*            TopicItem = new TreeViewItem()
                        {
                            Header = topic.Title,
                            Tag = topic
                        };*/

            CourseLayout.Items.Refresh();


            CourseName.Text = "";
            ModuleName.Text = "";


            txtTitle.Text = "";
        }



        //Go Back to Course Screen
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            CloseItemConfigurationMenu();

        }
        //Return
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CloseItemConfigurationMenu();
        }

        private void AddItemBelow_Configuration()
        {
            SaveTopic.Visibility = Visibility.Hidden;
            SaveTopicBelow.Visibility = Visibility.Visible;
            UpdateTopic.Visibility = Visibility.Hidden;

            SaveModule.Visibility = Visibility.Hidden;
            SaveModuleBelow.Visibility = Visibility.Visible;
            UpdateModule.Visibility = Visibility.Hidden;

            InputFields.Visibility = Visibility.Visible;
            ItemHeader.Visibility = Visibility.Visible;
        }


        //Opens Screen that makes it possible to add a Module/Topic
        //It Also Fills the textboxes with the right course/topic/module name
        private void AddItemBelow_MenuItem(object sender, RoutedEventArgs e)
        {



            TreeViewItem selectedTreeItem = (TreeViewItem)CourseLayout.SelectedItem;

            if (selectedTreeItem == null)
            {
                MessageBox.Show("Select An Item First");
            }

            else if (selectedTreeItem.Tag is CourseViewModel)
            {
                CourseName.Text = _course.Name;
                OpenTabModuleByCourse();
                AddItemBelow_Configuration();
            }
            else if (selectedTreeItem.Tag is Course_ModuleViewModel)
            {

                Course_ModuleViewModel selected = (Course_ModuleViewModel)selectedTreeItem.Tag;
                ModuleName.Text = selected.Title;
                CourseName.Text = _course.Name;
                OpenTabModule();
                AddItemBelow_Configuration();


            }
            else if (selectedTreeItem.Tag is Course_Module_TopicViewModel)
            {
                Course_Module_TopicViewModel selected = (Course_Module_TopicViewModel)selectedTreeItem.Tag;
                var query = Modules.Find(item => item.Id == selected.Course_ModuleId);
                ModuleName.Text = query.Title;
                CourseName.Text = _course.Name;
                OpenTabTopic();
                AddItemBelow_Configuration();


            }
            else if (selectedTreeItem.Tag is Course_Module_Topic_ElementViewModel)
            {
                MessageBox.Show("Cannot do it for now :)");
            }

        }

        private void AddItemAbove_Configuration()
        {
            SaveTopic.Visibility = Visibility.Visible;
            SaveTopicBelow.Visibility = Visibility.Hidden;
            UpdateTopic.Visibility = Visibility.Hidden;

            SaveModule.Visibility = Visibility.Visible;
            SaveModuleBelow.Visibility = Visibility.Hidden;
            UpdateModule.Visibility = Visibility.Hidden;

            InputFields.Visibility = Visibility.Visible;
            ItemHeader.Visibility = Visibility.Visible;
        }


        private void AddItemAbove_MenuItem(object sender, RoutedEventArgs e)
        {
            AddItemAbove_Configuration();

            TreeViewItem selectedTreeItem = (TreeViewItem)CourseLayout.SelectedItem;

            if (selectedTreeItem == null)
            {
                MessageBox.Show("Select An Item First");
            }

            else if (selectedTreeItem.Tag is CourseViewModel)
            {
                CourseName.Text = _course.Name;
                OpenTabModuleByCourse();
            }
            else if (selectedTreeItem.Tag is Course_ModuleViewModel)
            {

                Course_ModuleViewModel selected = (Course_ModuleViewModel)selectedTreeItem.Tag;

                ModuleName.Text = selected.Title;
                CourseName.Text = _course.Name;
                OpenTabModule();


            }
            else if (selectedTreeItem.Tag is Course_Module_TopicViewModel)
            {
                Course_Module_TopicViewModel selected = (Course_Module_TopicViewModel)selectedTreeItem.Tag;
                var query = Modules.Find(item => item.Id == selected.Course_ModuleId);
                ModuleName.Text = query.Title;

                CourseName.Text = _course.Name;
                OpenTabTopic();


            }
            else if (selectedTreeItem.Tag is Course_Module_Topic_ElementViewModel)
            {
                MessageBox.Show("Cannot do it for now :)");
            }
        }

        private void EditItem_Configuration()
        {
            SaveTopic.Visibility = Visibility.Hidden;
            SaveTopicBelow.Visibility = Visibility.Hidden;
            UpdateTopic.Visibility = Visibility.Visible;

            SaveModule.Visibility = Visibility.Hidden;
            SaveModuleBelow.Visibility = Visibility.Hidden;
            UpdateModule.Visibility = Visibility.Visible;

            InputFields.Visibility = Visibility.Visible;
            ItemHeader.Visibility = Visibility.Visible;

        }

        //Opens Screen that makes it possible to add a Module/Topic
        private void EditItem_MenuItem(object sender, RoutedEventArgs e)
        {

            EditItem_Configuration();


            TreeViewItem selectedTreeItem = (TreeViewItem)CourseLayout.SelectedItem;

            if (selectedTreeItem.Tag is CourseViewModel)
            {
                MessageBox.Show("Mag dat wel?");
            }
            else if (selectedTreeItem.Tag is Course_ModuleViewModel)
            {
                OpenTabModule();

                //Gets the selected treeview item (module)
                Course_ModuleViewModel selected = (Course_ModuleViewModel)selectedTreeItem.Tag;
                //Fills the textboxes with the right name
                CourseName.Text = _course.Name;
                ModuleName.Text = selected.Title;
                txtTitle.Text = selected.Title;



            }
            else if (selectedTreeItem.Tag is Course_Module_TopicViewModel)
            {
                OpenTabTopic();

                //Gets the selected treeview item (module)
                Course_Module_TopicViewModel selected = (Course_Module_TopicViewModel)selectedTreeItem.Tag;

                var query = Modules.Find(item => item.Id == selected.Course_ModuleId);

                CourseName.Text = _course.Name;
                ModuleName.Text = query.Title;
                tbTopic.Text = selected.Title;


            }
            else if (selectedTreeItem.Tag is Course_Module_Topic_ElementViewModel)
            {
                MessageBox.Show("Cannot do it for now :)");
            }
        }

        // Update button
        private void UpdateItem_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem selectedTreeItem = (TreeViewItem)CourseLayout.SelectedItem;

            if (selectedTreeItem.Tag is CourseViewModel)
            {
                MessageBox.Show("Cannot do this action");

            }
            else if (selectedTreeItem.Tag is Course_ModuleViewModel)
            {
                Course_ModuleViewModel selected = (Course_ModuleViewModel)selectedTreeItem.Tag;
                Course_ModuleViewModel updatedModule = new Course_ModuleViewModel();
                updatedModule.Id = selected.Id;
                updatedModule.Title = txtTitle.Text;
                updatedModule.Sortorder = selected.Sortorder;
                updatedModule.CourseId = selected.CourseId;
                PostModule(updatedModule);


            }
            else if (selectedTreeItem.Tag is Course_Module_TopicViewModel)
            {
                Course_Module_TopicViewModel selected = (Course_Module_TopicViewModel)selectedTreeItem.Tag;
                Course_Module_TopicViewModel updatedTopic = new Course_Module_TopicViewModel();
                updatedTopic.Id = selected.Id;
                updatedTopic.Title = tbTopic.Text;
                updatedTopic.Sortorder = selected.Sortorder;
                updatedTopic.Course_ModuleId = selected.Course_ModuleId;
                PostTopic(updatedTopic);

            }
            else if (selectedTreeItem.Tag is Course_Module_Topic_ElementViewModel)
            {
                MessageBox.Show("Cannot do it for now :)");
            }
            ///

            CloseItemConfigurationMenu();
            tbTopic.Text = "";
            ModuleName.Text = "";
            CourseName.Text = "";
            txtTitle.Text = "";

        }


        // Delete topic/module
        private async void DeleteItem_MenuItem(object sender, RoutedEventArgs e)
        {
            TreeViewItem selectedTreeItem = (TreeViewItem)CourseLayout.SelectedItem;

            if (selectedTreeItem.Tag is CourseViewModel)
            {
                MessageBox.Show("Kdenk ni da je zomaar een cursus mag verwijdere vriend");

            }
            else if (selectedTreeItem.Tag is Course_ModuleViewModel)
            {
                Course_ModuleViewModel selected = (Course_ModuleViewModel)selectedTreeItem.Tag;


                await HttpClientHelper<Course_ModuleViewModel>.HttpClientDeleteAsync(selected.Id, "Module");
                MessageBox.Show("Removed Module " + selected.Title);
                CreateTreeView();


            }
            else if (selectedTreeItem.Tag is Course_Module_TopicViewModel)
            {
                Course_Module_TopicViewModel selected = (Course_Module_TopicViewModel)selectedTreeItem.Tag;

                await HttpClientHelper<Course_Module_TopicViewModel>.HttpClientDeleteAsync(selected.Id, "Topic");
                MessageBox.Show("Removed Topic " + selected.Title);
                CreateTreeView();
            }
            else if (selectedTreeItem.Tag is Course_Module_Topic_ElementViewModel)
            {
                MessageBox.Show("Cannot do it for now :)");
            }

        }


        // Close layout
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            _coursesUserControl.LayoutView.Children.Clear();
            _coursesUserControl.LayoutView.Visibility = Visibility.Hidden;
            _coursesUserControl.PaginationGrid.Visibility = Visibility.Visible;
            _coursesUserControl.FilterView.Visibility = Visibility.Visible;
            _coursesUserControl.CourseMainView.Visibility = Visibility.Visible;
        }


        #endregion

        /// <summary>
        /// get mouse position to check if the drop valid position is
        /// </summary>
        private void treeView_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                Point currentPosition = e.GetPosition(CourseLayout);
                if ((Math.Abs(currentPosition.X - _lastMouseDown.X) > 10.0) ||
                    (Math.Abs(currentPosition.Y - _lastMouseDown.Y) > 10.0))
                {
                    // Verify that this is a valid drop and then store the drop target
                    TreeViewItem item = GetNearestContainer(e.OriginalSource as UIElement);
                    if (CheckDropTarget(draggedItem, item))
                    {
                        e.Effects = DragDropEffects.Move;
                    }
                    else
                    {
                        e.Effects = DragDropEffects.None;
                    }
                }
                e.Handled = true;
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// Check whether the target item is meeting your condition
        /// </summary>
        /// <returns></returns>
        private bool CheckDropTarget(TreeViewItem _sourceItem, TreeViewItem _targetItem)
        {
            bool _isEqual = false;
            if (!_sourceItem.Header.ToString().Equals(_targetItem.Header.ToString()))
            {
                _isEqual = true;
            }
            return _isEqual;
        }
        /// <summary>
        /// get nearest container to mouse position for drop the item
        /// </summary>
        private TreeViewItem GetNearestContainer(UIElement element)
        {
            // Walk up the element tree to the nearest tree view item.
            TreeViewItem container = element as TreeViewItem;
            while ((container == null) && (element != null))
            {
                element = VisualTreeHelper.GetParent(element) as UIElement;
                container = element as TreeViewItem;
            }
            return container;
        }
        /// <summary>
        /// Verify that this is a valid drop and then store the drop target
        /// </summary>
        private void treeView_Drop(object sender, DragEventArgs e)
        {
            try
            {
                e.Effects = DragDropEffects.None;
                e.Handled = true;
                TreeViewItem TargetItem = GetNearestContainer(e.OriginalSource as UIElement);
                if (TargetItem != null && draggedItem != null && TargetItem.Parent == draggedItem.Parent)
                {
                    _target = TargetItem;
                    e.Effects = DragDropEffects.Move;
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Checking target is not null and item is dragging(moving)
        /// </summary>
        private void treeView_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Point currentPosition = e.GetPosition(CourseLayout);
                    if ((Math.Abs(currentPosition.X - _lastMouseDown.X) > 10.0) ||
                        (Math.Abs(currentPosition.Y - _lastMouseDown.Y) > 10.0))
                    {
                        draggedItem = (TreeViewItem)CourseLayout.SelectedItem;
                        if (draggedItem != null)
                        {
                            DragDropEffects finalDropEffect =
                DragDrop.DoDragDrop(CourseLayout,
                    CourseLayout.SelectedValue,
                                DragDropEffects.Move);
                            //
                            if ((finalDropEffect == DragDropEffects.Move) &&
                    (_target != null))
                            {
                                // A Move drop was accepted
                                if (!draggedItem.Header.ToString().Equals
                    (_target.Header.ToString()))
                                {
                                    MoveItem(draggedItem, _target);
                                    _target = null;
                                    draggedItem = null;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Move the sourceitem and place it on the target item based on the index 
        /// </summary>
        private void MoveItem(TreeViewItem _sourceItem, TreeViewItem _targetItem)
        {
            try
            {
                TreeViewItem ParentItem = FindVisualParent<TreeViewItem>(_sourceItem);
                if (ParentItem != null)
                {
                    int index = ParentItem.Items.IndexOf(_sourceItem);
                    int index2 = ParentItem.Items.IndexOf(_targetItem);
                    ParentItem.Items.RemoveAt(index);
                    ParentItem.Items.Insert(index2, _sourceItem);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Get the parent element of the treeview
        /// </summary>
        static TObject FindVisualParent<TObject>(UIElement child) where TObject : UIElement
        {
            if (child == null)
            {
                return null;
            }
            UIElement parent = VisualTreeHelper.GetParent(child) as UIElement;
            while (parent != null)
            {
                TObject found = parent as TObject;
                if (found != null)
                {
                    return found;
                }
                else
                {
                    parent = VisualTreeHelper.GetParent(parent) as UIElement;
                }
            }
            return null;
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

        private void OpenTabTopic()
        {
            TopicTab.Visibility = Visibility.Visible;
            ModuleTab.Visibility = Visibility.Hidden;
            TopicTab.IsSelected = true;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ModuleTab.IsSelected)
                SelectedTabText.Text = "Module";

            else if (TopicTab.IsSelected)
                SelectedTabText.Text = "Topic";
        }


        private void OpenTabModuleByCourse()
        {

            TopicTab.Visibility = Visibility.Hidden;
            ModuleTab.Visibility = Visibility.Visible;
            ModuleTab.IsSelected = true;
        }

        private void OpenTabModule()
        {

            TopicTab.Visibility = Visibility.Visible;
            ModuleTab.Visibility = Visibility.Visible;
            ModuleTab.IsSelected = true;
        }



        private void CloseItemConfigurationMenu()
        {
            InputFields.Visibility = Visibility.Hidden;
            ItemHeader.Visibility = Visibility.Hidden;
            tbTopic.Text = "";
            ModuleName.Text = "";
            CourseName.Text = "";
            txtTitle.Text = "";
        }

        private void OnPreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem treeViewItem = VisualUpwardSearch(e.OriginalSource as DependencyObject);

            if (treeViewItem != null)
            {
                treeViewItem.Focus();
                e.Handled = true;
            }
        }

        static TreeViewItem VisualUpwardSearch(DependencyObject source)
        {
            while (source != null && !(source is TreeViewItem))
                source = VisualTreeHelper.GetParent(source);

            return source as TreeViewItem;
        }
    }
}