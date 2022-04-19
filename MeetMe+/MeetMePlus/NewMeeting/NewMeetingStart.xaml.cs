using MeetMe_.ClientService;
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

namespace MeetMe_.MeetMePlus.NewMeeting
{
    /// <summary>
    /// Interaction logic for NewMeetingStart.xaml
    /// </summary>
    public partial class NewMeetingStart : Page
    {
        Meeting newMeeting = new Meeting();
        User mainUser;
        List<Page> pages;
        MeetMePlus meetMePlusMain;
        public NewMeetingStart()
        {
            InitializeComponent();
        }
        public NewMeetingStart(MeetMePlus meetMePlus, User user)
        {
            InitializeComponent();
            mainUser = user;
            pages = meetMePlus.GetPages();
            meetMePlusMain = meetMePlus;
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (meetingNameTb.Text == "" || meetingAsdressTb.Text == "" || meetingDateTb.Text == "" || meetingTimeTb.Text == "")
            {
                MessageBox.Show("You must fill all fields", "Error");
                return;
            }
            newMeeting.Name = meetingNameTb.Text;
            newMeeting.Location = meetingAsdressTb.Text;
            newMeeting.MeetingTime = DateTime.Parse(meetingDateTb.Text + " " + meetingTimeTb.Text);
            newMeeting.Creator = mainUser;
            this.NavigationService.Navigate(new FinalNewMeeting(meetMePlusMain ,mainUser, newMeeting));
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            pages[3] = new CreateMeeting(meetMePlusMain, mainUser);
            meetMePlusMain.MenuLstView.SelectedIndex = 0;
            meetMePlusMain.AppFrame.Navigate(pages[0]);
        }
    }
}
