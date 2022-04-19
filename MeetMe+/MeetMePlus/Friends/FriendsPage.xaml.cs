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

namespace MeetMe_.MeetMePlus.Friends
{
    /// <summary>
    /// Interaction logic for FriendsPage.xaml
    /// </summary>
    public partial class FriendsPage : Page
    {
        ServiceClient serviceClient;
        User mainUser;
        Chat.ChatPage mainChatPage;
        FriendsList friends;
        public FriendsPage()
        {
            InitializeComponent();
        }

        public FriendsPage(User user, Chat.ChatPage chatPage)
        {
            InitializeComponent();
            mainUser = user;
            serviceClient = new ServiceClient();
            friends = serviceClient.Friend_SelectByUser(mainUser);
            mainChatPage = chatPage;
            foreach (Friend friend in friends)
            {
                    FriendsCard friendsCard = new FriendsCard(this, mainUser, friend, chatPage);
                    friendsLst.Children.Add(friendsCard);
            }
        }

        public void Reload()
        {
            friendsLst.Children.Clear();
            friends = serviceClient.Friend_SelectByUser(mainUser);
            foreach (Friend friend in friends)
            {
                FriendsCard friendsCard = new FriendsCard(this, mainUser, friend, mainChatPage);
                friendsLst.Children.Add(friendsCard);
            }
        }

        public Chat.ChatPage GetChatPage()
        {
            return mainChatPage;
        }
    }
}
