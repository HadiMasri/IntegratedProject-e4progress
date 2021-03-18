using E4Progress.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace E4Progress.UI.Views
{
    /// <summary>
    /// Interaction logic for QuizDetailsUserControl.xaml
    /// </summary>
    public partial class QuizDetailsUserControl : UserControl
    {
        QuizzesUserControl _quizzesUserControl;
        Quiz _quiz;
        public QuizDetailsUserControl(QuizzesUserControl quizzesUserControl, Quiz quiz)
        {
            InitializeComponent();
            _quizzesUserControl = quizzesUserControl;
            _quiz = quiz;
        }


        public void FillGrid()
        {
            TextQuestion.Text = _quiz.Title;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            _quizzesUserControl.DetailView.Children.Clear();
            _quizzesUserControl.DetailView.Visibility = Visibility.Hidden;
            _quizzesUserControl.QuizView.Visibility = Visibility.Visible;
            _quizzesUserControl.FilterView.Visibility = Visibility.Visible;
            _quizzesUserControl.PaginationGrid.Visibility = Visibility.Visible;
        }
    }
}
