﻿#pragma checksum "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1A1C6FA45978FAFE60FE66086E4F7C20AEFA83109AA12C174BCCAB99BA1B6D38"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MeetMe_.MeetMePlus;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace MeetMe_.MeetMePlus {
    
    
    /// <summary>
    /// MyAccount
    /// </summary>
    public partial class MyAccount : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame infoFrame;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel infoSwitchPanel;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel editBtnsPanel;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveBtn;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush profPic;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditImgBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MeetMe+;component/meetmeplus/myacc/myaccount.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 57 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.infoFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.infoSwitchPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            
            #line 77 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UserInfoBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 95 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ProfInfoBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.editBtnsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.saveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
            this.saveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 140 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.profPic = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 10:
            this.EditImgBtn = ((System.Windows.Controls.Button)(target));
            
            #line 202 "..\..\..\..\MeetMePlus\MyAcc\MyAccount.xaml"
            this.EditImgBtn.Click += new System.Windows.RoutedEventHandler(this.EditImgBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

