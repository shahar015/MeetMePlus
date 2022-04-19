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
    /// Interaction logic for MeetingsPage.xaml
    /// </summary>
    public partial class MeetingsPage : Page
    {
        User mainUser;
        MeetingsList meetingsList;
        public MeetingsPage()
        {
            InitializeComponent();

        }

        public MeetingsPage(User user)
        {
            InitializeComponent();
            mainUser = user;
            Load();
        }

        public void Load()
        {
            meetingsLst.Children.Clear();
            ServiceClient serviceClient = new ServiceClient();
            meetingsList = serviceClient.Meetings_SelectAllBesidesUser(mainUser);
            ParticipentsInMeetingList participentInMeetings = serviceClient.ParticipentsInMeeting_SelectAll();
            for (int i = 0; i < meetingsList.Count; i++)
            {
                bool isInMeeting = false;
                for (int b = 0; b < participentInMeetings.Count; b++)
                {
                    if (participentInMeetings[b].Meeting.Id == meetingsList[i].Id && participentInMeetings[b].Participent.Id == mainUser.Id)
                        isInMeeting = true;
                }
                if (isInMeeting)
                    meetingsList.Remove(meetingsList[i]);
            }
            foreach (Meeting meeting1 in meetingsList)
            {
                MeetingCard meetingCard = new MeetingCard(mainUser, meeting1, this);
                meetingsLst.Children.Add(meetingCard);
            }
        }

    }
}
