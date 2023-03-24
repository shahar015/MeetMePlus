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

namespace MeetMe_.MeetMePlus.Admin
{
    /// <summary>
    /// Interaction logic for AdminHomePage.xaml
    /// </summary>
    public partial class AdminHomePage : Page
    {
        NavigationService ns;
        User mainUser;
        List<Page> pages;
        MeetMePlus meetMePlusMain;
        public AdminHomePage(User user, MeetMePlus meetMePlus)
        {
            InitializeComponent();
            mainUser = user;
            meetMePlusMain = meetMePlus;
            pages = meetMePlusMain.GetAdminPages();
            ns = NavigationService.GetNavigationService(this);
        }

        private void MyAccount_Click(object sender, RoutedEventArgs e)
        {
            meetMePlusMain.AdminMenuLstView.SelectedIndex = 1;
            ns = NavigationService.GetNavigationService(this);
            ns.Navigate(pages[1]);
        }

        private void Meetings_Click(object sender, RoutedEventArgs e)
        {
            meetMePlusMain.AdminMenuLstView.SelectedIndex = 2;
            ns = NavigationService.GetNavigationService(this);
            ns.Navigate(pages[2]);
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            meetMePlusMain.AdminMenuLstView.SelectedIndex = 3;
            ns = NavigationService.GetNavigationService(this);
            ns.Navigate(pages[3]);
        }
    }
}
