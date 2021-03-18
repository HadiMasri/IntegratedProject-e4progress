﻿#pragma checksum "..\..\..\..\Views\UpdateQuestionDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F63E84179444539ACD6C994B431B8BA18CC3F74"
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
    /// UpdateQuestionDialog
    /// </summary>
    public partial class UpdateQuestionDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox questionTypeCombo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox masterQuestionCheckBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox masterQuestionCombo;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox instructionLanguageCombo;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox userLanguageCombo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox questionFormulationTypeCombo;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox officeApplicationCombo;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleTxt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox noteTxt;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox versionNrTxt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox questionTxt;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboThema;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboModelLevel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox isMesurableCheckBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLearningGoal;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSkills;
        
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
            System.Uri resourceLocater = new System.Uri("/E4Progress.UI;component/views/updatequestiondialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
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
            this.questionTypeCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.masterQuestionCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.masterQuestionCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.instructionLanguageCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.userLanguageCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.questionFormulationTypeCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.officeApplicationCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.titleTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
            this.titleTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.lettersValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 9:
            this.noteTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.versionNrTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
            this.versionNrTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 11:
            this.questionTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 37 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Dialog);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 38 "..\..\..\..\Views\UpdateQuestionDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Question);
            
            #line default
            #line hidden
            return;
            case 14:
            this.comboThema = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 15:
            this.comboModelLevel = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            this.isMesurableCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 17:
            this.txtLearningGoal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            this.txtSkills = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

