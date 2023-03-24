using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Chat.Themes;
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
    /// Interaction logic for ParticipantsWindow.xaml
    /// </summary>
    public partial class ParticipantsWindow : Window
    {
        User mainUser;
        Meeting mainMeeting;
        public ParticipantsWindow(Meeting meeting, User user)
        {
            InitializeComponent();
            mainUser = user; 
            mainMeeting = meeting;
            Load();
            this.DataContext = meeting;
        }
        public void Load()
        {
            ServiceClient service = new ServiceClient();
            ParticipentsInMeetingList participants = service.ParticipentsInMeeting_SelectByMeeting(mainMeeting);
            lvParticipants.Items.Clear();
            foreach (ParticipentInMeeting item in participants)
            {

                ParticipantCard participantCard = new ParticipantCard(item, mainUser, this);
                lvParticipants.Items.Add(participantCard);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
