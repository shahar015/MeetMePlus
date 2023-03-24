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

namespace MeetMe_.MeetMePlus.Meetings
{
    /// <summary>
    /// Interaction logic for MainMeetingsPage.xaml
    /// </summary>
    public partial class MainMeetingsPage : Page
    {
        List<Page> meetingsPages;
        int page;
        public MainMeetingsPage(User user)
        {
            InitializeComponent();
            meetingsPages = new List<Page>();
            page = 0;
            meetingsPages.Add(new MeetingsPage(user,this));
            page = 1;
            meetingsPages.Add(new MyMeetingsPage(user, this));
            meetingsPages.Add(new JoinedMeetingsPage(user, this));
            meetingsFrame.Navigate(meetingsPages[0]);

        }

        private void MeetingsList_Click(object sender, RoutedEventArgs e)
        {
            meetingsFrame.Navigate(meetingsPages[0]);
            page = 0;
        }

        public List<Page> GetMeetingsPages()
        {
            return meetingsPages;
        }

        private void JoinedMeetingsBtn_Click(object sender, RoutedEventArgs e)
        {
            meetingsFrame.Navigate(meetingsPages[2]);
            page = 2;
        }

        private void MyMeetingsBtn_Click(object sender, RoutedEventArgs e)
        {
            meetingsFrame.Navigate(meetingsPages[1]);
            page = 1;
        }

        public int GetPage()
        {
            return page;
        }
    }
}
