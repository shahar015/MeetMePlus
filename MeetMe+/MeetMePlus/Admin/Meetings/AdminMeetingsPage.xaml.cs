using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Admin.Meetings.Themes;
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

namespace MeetMe_.MeetMePlus.Admin.Meetings
{
    /// <summary>
    /// Interaction logic for AdminMeetingsPage.xaml
    /// </summary>
    public partial class AdminMeetingsPage : Page
    {
        User mainUser;
        public AdminMeetingsPage(User user)
        {
            InitializeComponent();
            mainUser = user;
            Load();
        }

        public void Load()
        {
            meetingsLst.Children.Clear();
            ServiceClient serviceClient = new ServiceClient();
            MeetingsList meetingsList = serviceClient.Meetings_SelectAll();
            foreach (Meeting meeting in meetingsList)
            {
                AdminMeetingCard meetingCard = new AdminMeetingCard(mainUser, meeting, this);
                meetingsLst.Children.Add(meetingCard);
            }
        }
    }
}
