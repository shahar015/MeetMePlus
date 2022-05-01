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
        public MainMeetingsPage(User user)
        {
            InitializeComponent();
            meetingsPages = new List<Page>();
            meetingsPages.Add(new MeetingsPage(user));
            meetingsPages.Add(new MyMeetingsPage(user));
            meetingsPages.Add(new JoinedMeetingsPage(user));
            meetingsFrame.Navigate(meetingsPages[0]);

        }

        private void MeetingsList_Click(object sender, RoutedEventArgs e)
        {
            meetingsFrame.Navigate(meetingsPages[0]);
        }

        private void JoinedMeetingsBtn_Click(object sender, RoutedEventArgs e)
        {
            meetingsFrame.Navigate(meetingsPages[2]);
        }

        private void MyMeetingsBtn_Click(object sender, RoutedEventArgs e)
        {
            meetingsFrame.Navigate(meetingsPages[1]);
        }
    }
}
