﻿#pragma checksum "..\..\..\..\Views\QuestionsUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A20F01FCF46DBB68364CA22244B05ECD52A3A189"
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
    /// QuestionsUserControl
    /// </summary>
    public partial class QuestionsUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleTxt;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox questionTypeCombo;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox officeApplicationCombo;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox instructionLanguageCombo;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox userLanguageCombo;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox noteTxt;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid questionDataGrid;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemNew;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemUpdate;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbNumberOfRows;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFirst;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPrev;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtPageInfo;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\Views\QuestionsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNext;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\Views\QuestionsUserControl.xaml"
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
            System.Uri resourceLocater = new System.Uri("/E4Progress.UI;component/views/questionsusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\QuestionsUserControl.xaml"
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
            this.titleTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.titleTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.lettersValidationTextBox);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.titleTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.titleTxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.questionTypeCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.questionTypeCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.questionTypeCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.officeApplicationCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 47 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.officeApplicationCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.officeApplicationCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.instructionLanguageCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 50 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.instructionLanguageCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.instructionLanguageCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.userLanguageCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.userLanguageCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.userLanguageCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.noteTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.noteTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.lettersValidationTextBox);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.noteTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.noteTxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 59 "..\..\..\..\Views\QuestionsUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Reset_Filter);
            
            #line default
            #line hidden
            return;
            case 9:
            this.questionDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.itemNew = ((System.Windows.Controls.MenuItem)(target));
            
            #line 77 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.itemNew.Click += new System.Windows.RoutedEventHandler(this.New_Question);
            
            #line default
            #line hidden
            return;
            case 11:
            this.itemUpdate = ((System.Windows.Controls.MenuItem)(target));
            
            #line 82 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.itemUpdate.Click += new System.Windows.RoutedEventHandler(this.Update_Question);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 87 "..\..\..\..\Views\QuestionsUserControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Question);
            
            #line default
            #line hidden
            return;
            case 13:
            this.CbNumberOfRows = ((System.Windows.Controls.ComboBox)(target));
            
            #line 100 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.CbNumberOfRows.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbNumberOfRows_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.BtnFirst = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.BtnFirst.Click += new System.Windows.RoutedEventHandler(this.BtnFirst_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.BtnPrev = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.BtnPrev.Click += new System.Windows.RoutedEventHandler(this.BtnPrev_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.TxtPageInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 17:
            this.BtnNext = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.BtnNext.Click += new System.Windows.RoutedEventHandler(this.BtnNext_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.BtnLast = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\Views\QuestionsUserControl.xaml"
            this.BtnLast.Click += new System.Windows.RoutedEventHandler(this.BtnLast_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

