#pragma checksum "..\..\..\..\Views\CoursesUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13DE8A093B7397F0478C31C13F7CB4685A52B40E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using E4Progress.UI.Strings;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Prism.Interactivity;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
using Prism.Unity;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using UIUtil;
using UIUtil.Extension;


namespace E4Progress.UI.Views {
    
    
    /// <summary>
    /// CoursesUserControl
    /// </summary>
    public partial class CoursesUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid FilterView;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CursusNameFiltertxt;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OfficeAppFilterCombo;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GebruikerTaalFilterCombo;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox InstructieTaalFilterCombo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CourseMainView;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CoursesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemNew;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemUpdate;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemLayout;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutView;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PaginationGrid;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbNumberOfRows;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFirst;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPrev;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtPageInfo;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNext;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Views\CoursesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLast;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/E4Progress.UI;component/views/coursesusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\CoursesUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TrainsitionigContentSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 2:
            this.FilterView = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.CursusNameFiltertxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.CursusNameFiltertxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CursusNameFiltertxt_TextChanged);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.CursusNameFiltertxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.lettersValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OfficeAppFilterCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.OfficeAppFilterCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OfficeAppCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GebruikerTaalFilterCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.GebruikerTaalFilterCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GebruikerTaalFilterCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.InstructieTaalFilterCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.InstructieTaalFilterCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.InstructieTaalFilterCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 51 "..\..\..\..\Views\CoursesUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reset_Filter);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CourseMainView = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.CoursesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.itemNew = ((System.Windows.Controls.MenuItem)(target));
            
            #line 71 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.itemNew.Click += new System.Windows.RoutedEventHandler(this.itemNew_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.itemUpdate = ((System.Windows.Controls.MenuItem)(target));
            
            #line 76 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.itemUpdate.Click += new System.Windows.RoutedEventHandler(this.Update_Course);
            
            #line default
            #line hidden
            return;
            case 12:
            this.itemLayout = ((System.Windows.Controls.MenuItem)(target));
            
            #line 81 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.itemLayout.Click += new System.Windows.RoutedEventHandler(this.itemLayout_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.LayoutView = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            this.PaginationGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 15:
            this.CbNumberOfRows = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.CbNumberOfRows.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbNumberOfRows_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.BtnFirst = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.BtnFirst.Click += new System.Windows.RoutedEventHandler(this.BtnFirst_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.BtnPrev = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.BtnPrev.Click += new System.Windows.RoutedEventHandler(this.BtnPrev_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.TxtPageInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 19:
            this.BtnNext = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.BtnNext.Click += new System.Windows.RoutedEventHandler(this.BtnNext_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.BtnLast = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\..\Views\CoursesUserControl.xaml"
            this.BtnLast.Click += new System.Windows.RoutedEventHandler(this.BtnLast_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

