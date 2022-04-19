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
    /// Interaction logic for FinalNewMeeting.xaml
    /// </summary>
    public partial class FinalNewMeeting : Page
    {
        Meeting mainMeeting;
        User mainUser;
        List<Page> pages;
        MeetMePlus meetMePlusMain;

        public FinalNewMeeting()
        {
            InitializeComponent();
        }

        public FinalNewMeeting(MeetMePlus meetMePlus, User user,Meeting meeting)
        {
            InitializeComponent();
            mainUser = user;
            mainMeeting = meeting;
            pages = meetMePlus.GetPages();
            meetMePlusMain = meetMePlus;
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (meetingDescTb.Text == "")
            {
                MessageBox.Show("You must fill all fields", "Error");
                return;
            }
            mainMeeting.Description=meetingDescTb.Text;
            mainMeeting.Creator = mainUser;
            MeetMe_.ClientService.ServiceClient serviceClient = new MeetMe_.ClientService.ServiceClient();
            serviceClient.Meetings_Insert(mainMeeting);
            MessageBox.Show("Meeting created successfuly", "Congrats!");
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            pages[3] = new CreateMeeting(meetMePlusMain, mainUser);
            meetMePlusMain.MenuLstView.SelectedIndex = 0;
            meetMePlusMain.AppFrame.Navigate(pages[0]);
        }
    }
}
