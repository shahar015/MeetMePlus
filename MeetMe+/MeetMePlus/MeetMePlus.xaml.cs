using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MeetMe_.MeetMePlus.Chat;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.NewMeeting;
using MeetMe_.MeetMePlus.Friends;
using MeetMe_.MeetMePlus.Meetings;

namespace MeetMe_.MeetMePlus
{
    /// <summary>
    /// Interaction logic for MeetMePlus.xaml
    /// </summary>
    public partial class MeetMePlus : Window
    {
        List<Page> pages;
        User mainUser;
        public MeetMePlus()
        {
            InitializeComponent();

        }

        public MeetMePlus(User user)
        {
            InitializeComponent();
            mainUser = user;
            pages = new List<Page>();
            pages.Add(new HomePage(mainUser, this));
            pages.Add(new ChatPage(mainUser));
            pages.Add(new MyAccount(mainUser));
            pages.Add(new CreateMeeting(this, mainUser));
            pages.Add(new FriendsPage(mainUser, pages[1] as ChatPage));
            pages.Add(new MeetingsPage(mainUser));
            mainUser = user;
            AppFrame.Navigate(pages[0]);
        }

        public List<Page> GetPages()
        {
            return pages;
        }

        private void OpenMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuBtn.Visibility = Visibility.Collapsed;
            CloseMenuBtn.Visibility = Visibility.Visible;
        }

        private void CloseMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuBtn.Visibility = Visibility.Visible;
            CloseMenuBtn.Visibility = Visibility.Collapsed;
        }

        private void HomeLstItem_Selected(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(pages[0]);
        }

        private void AccountLstItem_Selected(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(pages[2]);
        }

        private void ChatLstItem_Selected(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(pages[1]);
        }
        private void FriendsLstItem_Selected(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(pages[4]);
        }
        private void NewMeetingLstItem_Selected(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(pages[3]);
        }

        private void MeetingsLstItem_Selected(object sender, RoutedEventArgs e)
        {
            AppFrame.Navigate(pages[5]);
        }
    }
}
