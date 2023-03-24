using MeetMe_.ClientService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MeetMePlusWPF;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MeetMe_.MeetMePlus.Friends.Themes;
using MeetMe_.MeetMePlus.FriendsSug;

namespace MeetMe_.MeetMePlus.Friends
{
    /// <summary>
    /// Interaction logic for FriendsPage.xaml
    /// </summary>
    public partial class FriendsPage : Page
    {
        ServiceClient serviceClient;
        User mainUser;
        FriendsList friends;
        MeetMePlus mainMeetMePlus;
        FriendSuggestionsPage friendSuggestionsPage;
        public FriendsPage()
        {
            InitializeComponent();
        }

        public FriendsPage(User user, MeetMePlus meetMePlus)
        {
            InitializeComponent();
            mainUser = user;
            serviceClient = new ServiceClient();
            mainMeetMePlus = meetMePlus;
            Load();
        }

        public void Load()
        {
            friendsLst.Children.Clear();
            friends = serviceClient.Friend_SelectByUser(mainUser);
            foreach (Friend friend in friends)
            {
                FriendsCard friendsCard = new FriendsCard(mainUser, friend, mainMeetMePlus);
                friendsLst.Children.Add(friendsCard);
            }
            if (friendsLst.Children.Count == 0)
                makeFriendsSp.Visibility = Visibility.Visible;
            else
                makeFriendsSp.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            friendSuggestionsPage = mainMeetMePlus.GetUserPages()[6] as FriendSuggestionsPage;
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(mainMeetMePlus.GetUserPages()[6]);
            mainMeetMePlus.MenuLstView.SelectedIndex = 6;
        }
    }
}
