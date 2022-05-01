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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MeetMe_.MeetMePlus.Meetings.Themes
{
    /// <summary>
    /// Interaction logic for MeetingCard.xaml
    /// </summary>
    public partial class MeetingCard : UserControl
    {
        User mainUser;
        Meeting mainMeeting;
        MeetingsPage mainMeetingPage;
        ServiceClient serviceClient = new ServiceClient();
        ParticipentInMeeting mainPIM;

        public MeetingCard(User user, Meeting meeting, MeetingsPage meetingPage)
        {
            InitializeComponent();
            mainMeeting = meeting;
            mainUser = user;
            this.DataContext = mainMeeting;
            
            LeaveBtn.Visibility = Visibility.Hidden;
            EditBtn.Visibility = Visibility.Visible;
            joinBtn.Visibility = Visibility.Visible;
            mainMeetingPage = meetingPage;
            profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(mainMeeting.Creator);
            
        }

        public MeetingCard(User user, Meeting meeting)
        {
            InitializeComponent();
            mainMeeting = meeting;
            mainUser = user;
            this.DataContext = mainMeeting;
            joinBtn.Visibility=Visibility.Hidden;
            LeaveBtn.Visibility=Visibility.Hidden;
            EditBtn.Visibility=Visibility.Visible;
            profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(mainMeeting.Creator);

        }

        public MeetingCard(ParticipentInMeeting participentInMeeting)
        {
            InitializeComponent();
            mainMeeting = participentInMeeting.Meeting;
            mainUser = participentInMeeting.Participent;
            mainPIM = participentInMeeting;
            this.DataContext = mainMeeting;
            joinBtn.Visibility = Visibility.Hidden;
            EditBtn.Visibility = Visibility.Hidden;
            LeaveBtn.Visibility = Visibility.Visible;
            profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(mainMeeting.Creator);

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReadMoreWindow readMoreWindow = new ReadMoreWindow(mainMeeting);
            readMoreWindow.ShowDialog();
        }

        private void joinBtn_Click(object sender, RoutedEventArgs e)
        {
            
            ParticipentInMeeting participentInMeeting = new ParticipentInMeeting();
            participentInMeeting.Meeting = mainMeeting;
            participentInMeeting.Participent = mainUser;
            int i = serviceClient.ParticipentInMeeting_Insert(participentInMeeting);
            if (i!=0)
            MessageBox.Show("Added successfuly", "Success");
            mainMeetingPage.Load();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            EditMeetingWindow win = new EditMeetingWindow(mainMeeting);
            win.ShowDialog();
            mainMeeting = serviceClient.Meeting_SelectById(mainMeeting.Id);
            this.DataContext = mainMeeting;
            MessageBox.Show("Edited successfuly", "Success");
        }

        private void LeaveBtn_Click(object sender, RoutedEventArgs e)
        {
            serviceClient.ParticipentInMeeting_Delete(mainPIM);
            MessageBox.Show("Added successfuly", "Success");
        }
    }
}
