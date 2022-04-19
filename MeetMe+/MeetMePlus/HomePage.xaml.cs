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
using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Chat;
using MeetMe_.MeetMePlus.Friends;
using MeetMe_.MeetMePlus.NewMeeting;

namespace MeetMe_.MeetMePlus
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        NavigationService ns ;
        User mainUser;
        List<Page> pages;
        MeetMePlus meetMePlusMain;
        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(User user, MeetMePlus meetMePlus)
        {
            InitializeComponent();
            mainUser = user;
            meetMePlusMain = meetMePlus;
            pages = meetMePlusMain.GetPages();
            ns = NavigationService.GetNavigationService(this);

        }

        private void Chat_Click(object sender, RoutedEventArgs e)
        {
            meetMePlusMain.MenuLstView.SelectedIndex = 5;
            ns = NavigationService.GetNavigationService(this);
            ns.Navigate(pages[1]);
        }

        private void MyAccount_Click(object sender, RoutedEventArgs e)
        {
            meetMePlusMain.MenuLstView.SelectedIndex = 1;
            ns = NavigationService.GetNavigationService(this);
            ns.Navigate(pages[2]);
        }

        private void CreateMeeting_Click(object sender, RoutedEventArgs e)
        {
            meetMePlusMain.MenuLstView.SelectedIndex = 3;
            ns = NavigationService.GetNavigationService(this);
            ns.Navigate(pages[3]);
        }

        private void Friends_Click(object sender, RoutedEventArgs e)
        {
            meetMePlusMain.MenuLstView.SelectedIndex = 2;
            ns = NavigationService.GetNavigationService(this);
            ns.Navigate(pages[4]);
        }

        private void Meetings_Click(object sender, RoutedEventArgs e)
        {
            meetMePlusMain.MenuLstView.SelectedIndex = 4;
            ns = NavigationService.GetNavigationService(this);
            ns.Navigate(pages[5]);
        }
    }
}
