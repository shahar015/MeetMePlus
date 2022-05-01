using MeetMe_.ClientService;
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
        public EditMeetingWindow()
        {
            InitializeComponent();
        }
        public EditMeetingWindow(Meeting meeting)
        {
            InitializeComponent();
            this.DataContext = meeting;
            meetingDateTb.Text = meeting.MeetingTime.ToLongDateString();
            meetingDateTb.Text = meeting.MeetingTime.ToShortTimeString();
            mainMeeting = meeting;
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
            mainMeeting.MeetingTime = DateTime.ParseExact(meetingDateTb.Text + " " + meetingTimeTb.Text, "d/M/yyyy H:m", CultureInfo.InvariantCulture);
            serviceClient.Meetings_Update(mainMeeting);
        }
    }
}
