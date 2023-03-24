using MeetMe_.ClientService;
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

namespace MeetMe_.MeetMePlus.Meetings
{
    /// <summary>
    /// Interaction logic for JoinedMeetingsPage.xaml
    /// </summary>
    public partial class JoinedMeetingsPage : Page
    {
        User mainUser;
        MainMeetingsPage mainMeetingsPage;
        public JoinedMeetingsPage()
        {
            InitializeComponent();

        }

        public JoinedMeetingsPage(User user, MainMeetingsPage mainMeetingsPage)
        {
            InitializeComponent();
            mainUser = user;
            this.mainMeetingsPage = mainMeetingsPage;
            Load();
        }

        public void Load()
        {
            meetingsLst.Children.Clear();
            ServiceClient serviceClient = new ServiceClient();
            ParticipentsInMeetingList participentInMeetings = serviceClient.ParticipentsInMeeting_SelectByUser(mainUser);
            foreach (ParticipentInMeeting participentInMeeting in participentInMeetings)
            {
                MeetingCard meetingCard = new MeetingCard(participentInMeeting, mainMeetingsPage);
                meetingsLst.Children.Add(meetingCard);
            }
        }
    }
}
