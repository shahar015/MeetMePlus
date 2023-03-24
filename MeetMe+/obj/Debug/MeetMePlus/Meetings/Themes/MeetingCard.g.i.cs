﻿#pragma checksum "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B7070A28704B0AA869467B18871CA2A50402CB4CDF6ADD86DAE7A169081D8DC6"
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
using MeetMe_.MeetMePlus.Meetings.Themes;
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


namespace MeetMe_.MeetMePlus.Meetings.Themes {
    
    
    /// <summary>
    /// MeetingCard
    /// </summary>
    public partial class MeetingCard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush profPic;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtn;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeaveBtn;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button joinBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/MeetMe+;component/meetmeplus/meetings/themes/meetingcard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
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
            
            #line 36 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.profPic = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 3:
            
            #line 97 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 118 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 139 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
            this.EditBtn.Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LeaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 170 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
            this.LeaveBtn.Click += new System.Windows.RoutedEventHandler(this.LeaveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.joinBtn = ((System.Windows.Controls.Button)(target));
            
            #line 201 "..\..\..\..\..\MeetMePlus\Meetings\Themes\MeetingCard.xaml"
            this.joinBtn.Click += new System.Windows.RoutedEventHandler(this.joinBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
