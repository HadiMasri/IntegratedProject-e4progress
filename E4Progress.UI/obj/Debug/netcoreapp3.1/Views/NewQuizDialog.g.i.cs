﻿#pragma checksum "..\..\..\..\Views\NewQuizDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19E8A8355ED6A9AD975BF22B9C418F143A26812B"
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
    /// NewQuizDialog
    /// </summary>
    public partial class NewQuizDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Window;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Header;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PickerOffice;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PickerInstructionLanguage;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PickerUILanguage;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextTitle;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextShortIntro;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextIntro;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextMinScore;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextHours;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextMinutes;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextSeconds;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextIdentificationCode;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonReturn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Views\NewQuizDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonConfirm;
        
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
            System.Uri resourceLocater = new System.Uri("/E4Progress.UI;component/views/newquizdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\NewQuizDialog.xaml"
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
            this.Window = ((System.Windows.Controls.Grid)(target));
            
            #line 18 "..\..\..\..\Views\NewQuizDialog.xaml"
            this.Window.Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.PickerOffice = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.PickerInstructionLanguage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.PickerUILanguage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TextTitle = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\Views\NewQuizDialog.xaml"
            this.TextTitle.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.lettersValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TextShortIntro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TextIntro = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.TextMinScore = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.TextHours = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\..\Views\NewQuizDialog.xaml"
            this.TextHours.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TextMinutes = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\..\Views\NewQuizDialog.xaml"
            this.TextMinutes.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 12:
            this.TextSeconds = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\..\Views\NewQuizDialog.xaml"
            this.TextSeconds.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 13:
            this.TextIdentificationCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.ButtonReturn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Views\NewQuizDialog.xaml"
            this.ButtonReturn.Click += new System.Windows.RoutedEventHandler(this.ButtonReturn_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.ButtonConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Views\NewQuizDialog.xaml"
            this.ButtonConfirm.Click += new System.Windows.RoutedEventHandler(this.ButtonConfirm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

