using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.FriendsSug.Themes;
using MeetMe_.MeetMePlus.Meetings;
using MeetMe_.MeetMePlus.Meetings.Themes;
using System;
using System.Collections.Generic;
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

namespace MeetMe_.MeetMePlus.Admin.Meetings.Themes
{
    /// <summary>
    /// Interaction logic for AdminMeetingCard.xaml
    /// </summary>
    public partial class AdminMeetingCard : UserControl
    {
        Meeting mainMeeting;
        AdminMeetingsPage mainMeetingPage;
        User mainUser;
        ServiceClient serviceClient = new ServiceClient();
        public AdminMeetingCard(User user,Meeting meeting, AdminMeetingsPage meetingPage)
        {
            InitializeComponent();
            mainUser=user;
            mainMeeting = meeting;
            this.DataContext = mainMeeting;
            mainMeetingPage = meetingPage;
            profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(mainMeeting.Creator);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReadMoreWindow readMoreWindow = new ReadMoreWindow(mainMeeting);
            readMoreWindow.ShowDialog();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            EditMeetingWindow readMoreWindow = new EditMeetingWindow(mainMeeting, mainMeetingPage);
            readMoreWindow.ShowDialog();
            mainMeeting = serviceClient.Meeting_SelectById(mainMeeting.Id);
            this.DataContext = mainMeeting;
            MessageBox.Show("Edited successfuly", "Success");

        }


        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure you want to remove friend?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ParticipentsInMeetingList participentInMeetings = serviceClient.ParticipentsInMeeting_SelectAll();
                foreach (ParticipentInMeeting participentInMeeting in participentInMeetings)
                {
                    if (mainMeeting.Id == participentInMeeting.Meeting.Id)
                        serviceClient.ParticipentInMeeting_Delete(participentInMeeting);
                }
                serviceClient.Meetings_Delete(mainMeeting);
                mainMeetingPage.Load();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserReadMoreWindow userReadMoreWindow = new UserReadMoreWindow(mainMeeting.Creator);
            userReadMoreWindow.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ParticipantsWindow window = new ParticipantsWindow(mainMeeting, mainUser);
            window.ShowDialog();
        }
    }
}
