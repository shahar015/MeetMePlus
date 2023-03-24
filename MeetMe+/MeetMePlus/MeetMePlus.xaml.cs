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
using MeetMe_.MeetMePlus.FriendsSug;
using MeetMe_.MeetMePlus.Admin;
using MeetMe_.MeetMePlus.Admin.Meetings;
using MeetMePlusWPF;

namespace MeetMe_.MeetMePlus
{
    /// <summary>
    /// Interaction logic for MeetMePlus.xaml
    /// </summary>
    public partial class MeetMePlus : Window
    {
        List<Page> userPages;
        List<Page> adminPages;
        User mainUser;
        public MeetMePlus()
        {
            InitializeComponent();

        }

        public MeetMePlus(User user)
        {
            InitializeComponent();
            mainUser = user;
            userPages = new List<Page>();
            adminPages = new List<Page>();
            if (user.UserType.Name == "Admin")
            {
                LoadAdminPages();
                switchUserBtn.Visibility = Visibility.Visible;
                gridMenu.Visibility = Visibility.Hidden;
                adminGridMenu.Visibility = Visibility.Visible;
                admin.Visibility = Visibility.Visible;
                AppFrame.Navigate(adminPages[0]);
            }
            else
            {
                LoadPages();
                AppFrame.Navigate(userPages[0]);
            }

            

           
        }
        private void LoadPages()
        {
            userPages.Add(new HomePage(mainUser, this));
            userPages.Add(new ChatPage(mainUser));
            userPages.Add(new MyAccount(mainUser, this));
            userPages.Add(new CreateMeeting(this, mainUser));
            userPages.Add(new FriendsPage(mainUser, this));
            userPages.Add(new MainMeetingsPage(mainUser));
            userPages.Add(new FriendSuggestionsPage(mainUser, userPages[4] as FriendsPage));
        }

        private void LoadAdminPages()
        {
            adminPages.Add(new AdminHomePage(mainUser, this));
            adminPages.Add(new MyAccount(mainUser, this));
            adminPages.Add(new AdminMeetingsPage(mainUser));
            adminPages.Add(new AdminAccountsPage(mainUser));
        }

        public List<Page> GetUserPages()
        {
            return userPages;
        }
        public List<Page> GetAdminPages()
        {
            return adminPages;
        }

        #region regMenu

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
                AppFrame.Navigate(userPages[0]);
        }

        private void AccountLstItem_Selected(object sender, RoutedEventArgs e)
        {
                AppFrame.Navigate(userPages[2]);
        }

        private void ChatLstItem_Selected(object sender, RoutedEventArgs e)
        {
                AppFrame.Navigate(userPages[1]);
        }
        private void FriendsLstItem_Selected(object sender, RoutedEventArgs e)
        {
                AppFrame.Navigate(userPages[4]);
        }
        private void NewMeetingLstItem_Selected(object sender, RoutedEventArgs e)
        {
                AppFrame.Navigate(userPages[3]);
        }

        private void MeetingsLstItem_Selected(object sender, RoutedEventArgs e)
        {
                AppFrame.Navigate(userPages[5]);
        }

        private void SugLstItem_Selected(object sender, RoutedEventArgs e)
        {
                AppFrame.Navigate(userPages[6]);
        }
        #endregion

        #region adMenu

        private void AdminOpenMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            AdminOpenMenuBtn.Visibility = Visibility.Collapsed;
            AdminCloseMenuBtn.Visibility = Visibility.Visible;
        }


        private void AdminCloseMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            AdminOpenMenuBtn.Visibility = Visibility.Visible;
            AdminCloseMenuBtn.Visibility = Visibility.Collapsed;
        }

        private void AdminHomeLstItem_Selected(object sender, RoutedEventArgs e)
        {
            if (mainUser.UserType.Name == "Admin")
                AppFrame.Navigate(adminPages[0]);
        }

        private void AdminAccountLstItem_Selected(object sender, RoutedEventArgs e)
        {
            if (mainUser.UserType.Name == "Admin")
                AppFrame.Navigate(adminPages[1]);
        }

        private void AdminMeetingsLstItem_Selected(object sender, RoutedEventArgs e)
        {
            if (mainUser.UserType.Name == "Admin")
                AppFrame.Navigate(adminPages[2]);
        }
        private void AdminAccountsLstItem_Selected(object sender, RoutedEventArgs e)
        {
            if (mainUser.UserType.Name == "Admin")
                AppFrame.Navigate(adminPages[3]);
        }
        #endregion

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void SwitchToAdmin_Click(object sender, RoutedEventArgs e)
        {
            adminPages.Clear();
            LoadAdminPages();
            AppFrame.Navigate(adminPages[0]);
            gridMenu.Visibility = Visibility.Hidden;
            adminGridMenu.Visibility = Visibility.Visible;
            admin.Visibility = Visibility.Visible;
           
        }

        private void SwitchToUser_Click(object sender, RoutedEventArgs e)
        {
            userPages.Clear();
            LoadPages();
            switchAdminBtn.Visibility = Visibility.Visible;
            AppFrame.Navigate(userPages[0]);
            switchAdminBtn.Visibility = Visibility.Visible;
            gridMenu.Visibility = Visibility.Visible;
            adminGridMenu.Visibility = Visibility.Hidden;
            admin.Visibility = Visibility.Hidden;
        }
    }
}
