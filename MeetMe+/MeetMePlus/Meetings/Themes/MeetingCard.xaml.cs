using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Admin.Meetings.Themes;
using MeetMe_.MeetMePlus.FriendsSug.Themes;
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
        MainMeetingsPage mainMeetingsPage;
        ServiceClient serviceClient = new ServiceClient();
        ParticipentInMeeting mainPIM;

        public MeetingCard(User user, Meeting meeting, MainMeetingsPage mainMeetingsPage)
        {
            InitializeComponent();
            mainMeeting = meeting;
            mainUser = user;
            this.DataContext = mainMeeting;
            int page = mainMeetingsPage.GetPage();
            LeaveBtn.Visibility = Visibility.Hidden;
            EditBtn.Visibility = Visibility.Visible;
            joinBtn.Visibility = Visibility.Visible;
            if (page == 1)
            {
                joinBtn.Visibility = Visibility.Hidden;
                LeaveBtn.Visibility = Visibility.Hidden;
                EditBtn.Visibility = Visibility.Visible;
            }
            this.mainMeetingsPage = mainMeetingsPage;
            profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(mainMeeting.Creator);
        }

        //public MeetingCard(User user, Meeting meeting)
        //{
        //    InitializeComponent();
        //    mainMeeting = meeting;
        //    mainUser = user;
        //    this.DataContext = mainMeeting;
        //    joinBtn.Visibility = Visibility.Hidden;
        //    LeaveBtn.Visibility = Visibility.Hidden;
        //    EditBtn.Visibility = Visibility.Visible;
        //    profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(mainMeeting.Creator);
        //}

        public MeetingCard(
            ParticipentInMeeting participentInMeeting,
            MainMeetingsPage mainMeetingsPage
        )
        {
            InitializeComponent();
            mainMeeting = participentInMeeting.Meeting;
            mainUser = participentInMeeting.Participent;
            mainPIM = participentInMeeting;
            this.DataContext = mainMeeting;
            this.mainMeetingsPage = mainMeetingsPage;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ParticipantsWindow window = new ParticipantsWindow(mainMeeting, mainUser);
            window.ShowDialog();
        }

        private void joinBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(
   "Are you sure you want to join meeting?",
   "Add Confirmation",
   System.Windows.MessageBoxButton.YesNo
);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ParticipentInMeeting participentInMeeting = new ParticipentInMeeting();
                List<Page> pages = mainMeetingsPage.GetMeetingsPages();
                participentInMeeting.Meeting = mainMeeting;
                participentInMeeting.Participent = mainUser;
                int i = serviceClient.ParticipentInMeeting_Insert(participentInMeeting);
                if (i != 0)
                    MessageBox.Show("Added successfuly", "Success");
                (pages[0] as MeetingsPage).Load();
                (pages[2] as JoinedMeetingsPage).Load();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Page> pages = mainMeetingsPage.GetMeetingsPages();
            EditMeetingWindow win = new EditMeetingWindow(mainMeeting, pages[1] as MyMeetingsPage);
            win.ShowDialog();
            mainMeeting = serviceClient.Meeting_SelectById(mainMeeting.Id);
            this.DataContext = mainMeeting;
            MessageBox.Show("Edited successfuly", "Success");
        }

        private void LeaveBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(
               "Are you sure you want to leave meeting?",
               "Add Confirmation",
               System.Windows.MessageBoxButton.YesNo
           );
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                List<Page> pages = mainMeetingsPage.GetMeetingsPages();
                serviceClient.ParticipentInMeeting_Delete(mainPIM);
                (pages[0] as MeetingsPage).Load();
                (pages[2] as JoinedMeetingsPage).Load();
                MessageBox.Show("Added successfuly", "Success");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserReadMoreWindow userReadMoreWindow = new UserReadMoreWindow(mainMeeting.Creator);
            userReadMoreWindow.ShowDialog();
        }
    }
}
