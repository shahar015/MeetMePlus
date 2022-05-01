using MeetMe_.ClientService;
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

namespace MeetMe_.MeetMePlus.Friends.Themes
{
    /// <summary>
    /// Interaction logic for FriendsCard.xaml
    /// </summary>
    public partial class FriendsCard : UserControl
    {
        Friend mainFriend;
        FriendsPage mainFriendsPage;
        User mainUser;
        Chat.ChatPage mainChatPage;
        MeetMePlus mainMeetMePlus;
        public FriendsCard()
        {
            InitializeComponent();
        }
        public FriendsCard(FriendsPage friendsPage, User user, Friend friend, Chat.ChatPage chatPage, MeetMePlus meetMePlus)
        {
            InitializeComponent();
            mainFriend = friend;
            mainFriendsPage = friendsPage;
            mainUser = user;
            mainChatPage = chatPage;
            mainMeetMePlus = meetMePlus;
            if (user.Username == friend.User1.Username)
            {
                this.DataContext = friend.User2;
                profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(friend.User2);
            }

            else
            {
                this.DataContext = friend.User1;
                profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(friend.User1);
            }
        }

        private void deleteFriendBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure you want to remove friend?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ServiceClient serviceClient = new ServiceClient();
                serviceClient.Friends_Delete(mainFriend);
                ClientService.Chat chat = serviceClient.Chat_SelectByUsers(mainFriend.User2, mainFriend.User1);
                serviceClient.Message_DeleteFromChat(chat);
                serviceClient.Chat_Delete(chat);
                mainFriendsPage.Load();
                mainChatPage.LoadChatHeaders(serviceClient.Chat_SelectByUser(mainUser));
            }
        }

        private void ChatFriendBtn_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient serviceClient = new ServiceClient();
            ClientService.Chat chat = serviceClient.Chat_SelectByUsers(mainFriend.User2, mainFriend.User1);
            mainMeetMePlus.MenuLstView.SelectedIndex = 5;
            if (chat==null)
            {
                chat = new ClientService.Chat();
                chat.User1 = mainFriend.User1;
                chat.User2 = mainFriend.User2;
                serviceClient.Chat_Insert(chat);
            }
            mainChatPage.LoadChatTextFriends(chat);
            NavigationService ns= NavigationService.GetNavigationService(mainFriendsPage);
            ns.Navigate(mainFriendsPage.GetChatPage());
        }
    }
}
