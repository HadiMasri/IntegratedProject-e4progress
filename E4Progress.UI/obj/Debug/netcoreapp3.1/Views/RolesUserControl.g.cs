#pragma checksum "..\..\..\..\Views\RolesUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8318095A2B9F9F2FFED7B11B97FFCFFE471AC47B"
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
    /// RolesUserControl
    /// </summary>
    public partial class RolesUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Views\RolesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\RolesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer SVUserList;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\RolesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtFilter;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\RolesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditUser;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\RolesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteUser;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\RolesUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RoleListView;
        
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
            System.Uri resourceLocater = new System.Uri("/E4Progress.UI;component/views/rolesusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\RolesUserControl.xaml"
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
            this.SVUserList = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 24 "..\..\..\..\Views\RolesUserControl.xaml"
            this.SVUserList.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.SVUserList_PreviewMouseWheel);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\..\..\Views\RolesUserControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxtFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\..\Views\RolesUserControl.xaml"
            this.TxtFilter.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.lettersValidationTextBox);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\..\Views\RolesUserControl.xaml"
            this.TxtFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtFilter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnEditUser = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Views\RolesUserControl.xaml"
            this.BtnEditUser.Click += new System.Windows.RoutedEventHandler(this.BtnEditUser_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnDeleteUser = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Views\RolesUserControl.xaml"
            this.BtnDeleteUser.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteUser_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RoleListView = ((System.Windows.Controls.ListBox)(target));
            
            #line 45 "..\..\..\..\Views\RolesUserControl.xaml"
            this.RoleListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RoleListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

