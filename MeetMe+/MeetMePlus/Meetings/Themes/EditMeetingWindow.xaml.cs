using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Admin.Meetings;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MeetMe_.MeetMePlus.Meetings.Themes
{
    /// <summary>
    /// Interaction logic for EditMeetingWindow.xaml
    /// </summary>
    public partial class EditMeetingWindow : Window
    {
        Meeting mainMeeting;
        MyMeetingsPage mainMeetingsPage;
        AdminMeetingsPage mainAdminMeetingsPage;

        public EditMeetingWindow()
        {
            InitializeComponent();
        }

        public EditMeetingWindow(Meeting meeting, MyMeetingsPage meetingsPage)
        {
            InitializeComponent();
            meetingDateTb.Text = meeting.MeetingTime.ToLongDateString();
            meetingTimeTb.Text = meeting.MeetingTime.ToShortTimeString();
            mainMeeting = meeting;
            mainMeetingsPage = meetingsPage;
            this.DataContext = mainMeeting;
        }

        public EditMeetingWindow(Meeting meeting, AdminMeetingsPage meetingsPage)
        {
            InitializeComponent();
            meetingDateTb.Text = meeting.MeetingTime.ToLongDateString();
            meetingTimeTb.Text = meeting.MeetingTime.ToShortTimeString();
            mainMeeting = meeting;
            mainAdminMeetingsPage = meetingsPage;
            this.DataContext = mainMeeting;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient serviceClient = new ServiceClient();
            mainMeeting.MeetingTime = DateTime.ParseExact(
                meetingDateTb.Text + " " + meetingTimeTb.Text,
                "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture
            );
            serviceClient.Meetings_Update(mainMeeting);
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(
                "Are you sure you want to remove friend?",
                "Delete Confirmation",
                System.Windows.MessageBoxButton.YesNo
            );
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ServiceClient serviceClient = new ServiceClient();
                serviceClient.ParticipentsInMeeting_DeleteByMeeting(mainMeeting);
                serviceClient.Meetings_Delete(mainMeeting);
                if (mainMeetingsPage != null)
                    mainMeetingsPage.Load();
                else
                    mainAdminMeetingsPage.Load();
                this.Close();
            }
        }
    }
}
