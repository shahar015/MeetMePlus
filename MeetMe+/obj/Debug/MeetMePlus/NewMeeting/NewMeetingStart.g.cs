﻿#pragma checksum "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1B2784F0689FD3AC318DF63B921604061A6279F233E4BC430532B833731E349E"
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
using MeetMe_.MeetMePlus.NewMeeting;
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


namespace MeetMe_.MeetMePlus.NewMeeting {
    
    
    /// <summary>
    /// NewMeetingStart
    /// </summary>
    public partial class NewMeetingStart : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox meetingNameTb;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox meetingAsdressTb;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker meetingDateTb;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker meetingTimeTb;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextBtn;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/MeetMe+;component/meetmeplus/newmeeting/newmeetingstart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml"
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
            this.meetingNameTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.meetingAsdressTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.meetingDateTb = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.meetingTimeTb = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 5:
            this.nextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml"
            this.nextBtn.Click += new System.Windows.RoutedEventHandler(this.NextBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\..\MeetMePlus\NewMeeting\NewMeetingStart.xaml"
            this.cancelBtn.Click += new System.Windows.RoutedEventHandler(this.CancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

