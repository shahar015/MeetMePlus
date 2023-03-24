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
    /// Interaction logic for MyMeetingsPage.xaml
    /// </summary>
    public partial class MyMeetingsPage : Page
    {

        User mainUser;
        MeetingsList meetingsList;
        MainMeetingsPage mainMeetingsPage;

        public MyMeetingsPage(User user, MainMeetingsPage mainMeetingsPage)
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
            meetingsList = serviceClient.Meetings_SelectByUser(mainUser);
            foreach (Meeting meeting1 in meetingsList)
            {
                MeetingCard meetingCard = new MeetingCard(mainUser, meeting1, mainMeetingsPage);
                meetingsLst.Children.Add(meetingCard);
            }
        }
    }
}
