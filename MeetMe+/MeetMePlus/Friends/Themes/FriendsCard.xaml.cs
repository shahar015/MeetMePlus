using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.FriendsSug;
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

namespace MeetMe_.MeetMePlus.Friends.Themes
{
    /// <summary>
    /// Interaction logic for FriendsCard.xaml
    /// </summary>
    public partial class FriendsCard : UserControl
    {
        Friend mainFriend;
        FriendsPage friendsPage;
         Chat.ChatPage chatPage;
        FriendSuggestionsPage friendSuggestionsPage;
        User mainUser;
        User otherUser;

        MeetMePlus mainMeetMePlus;
        public FriendsCard()
        {
            InitializeComponent();
        }

        public FriendsCard(
            User user,
            Friend friend,
            MeetMePlus meetMePlus
        )
        {
            InitializeComponent();
            mainFriend = friend;
            mainUser = user;
            
            mainMeetMePlus = meetMePlus;
            if (user.Id == friend.User1.Id)
            {
                this.DataContext = friend.User2;
                otherUser = friend.User2;
                profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(friend.User2);
            }
            else
            {
                this.DataContext = friend.User1;
                otherUser = friend.User2;
                profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(friend.User1);
            }
        }

        private void deleteFriendBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(
                "Are you sure you want to remove friend?",
                "Delete Confirmation",
                System.Windows.MessageBoxButton.YesNo
            );
                List<Page> pages = mainMeetMePlus.GetUserPages();
            friendsPage = pages[4] as FriendsPage;
            friendSuggestionsPage = pages[6] as FriendSuggestionsPage;
            chatPage = pages[1] as Chat.ChatPage;
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ServiceClient serviceClient = new ServiceClient();
                serviceClient.Friends_Delete(mainFriend);
                ClientService.Chat chat = serviceClient.Chat_SelectByUsers(
                    mainFriend.User2,
                    mainFriend.User1
                );
                if (chat!=null)
                {
                    serviceClient.Message_DeleteFromChat(chat);
                    serviceClient.Chat_Delete(chat);
                    chatPage.LoadChatHeaders(serviceClient.Chat_SelectByUser(mainUser));
                }
                friendsPage.Load();
                friendSuggestionsPage.Load();
            }
        }

        private void ChatFriendBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Page> pages = mainMeetMePlus.GetUserPages();
            friendsPage = pages[4] as FriendsPage;
            friendSuggestionsPage = pages[6] as FriendSuggestionsPage;
            chatPage = pages[1] as Chat.ChatPage;
            ServiceClient serviceClient = new ServiceClient();
            ClientService.Chat chat = serviceClient.Chat_SelectByUsers(
                mainFriend.User2,
                mainFriend.User1
            );
            mainMeetMePlus.MenuLstView.SelectedIndex = 5;
            if (chat == null)
            {
                chat = new ClientService.Chat();
                chat.User1 = mainFriend.User1;
                chat.User2 = mainFriend.User2;
                serviceClient.Chat_Insert(chat);
                chat = serviceClient.Chat_SelectByUsers(chat.User1, chat.User2);
                chatPage.AddChatHeader(chat);
            }
            chatPage.LoadChatTextFriends(chat);
            NavigationService ns = NavigationService.GetNavigationService(friendsPage);
            ns.Navigate(chatPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserReadMoreWindow userReadMoreWindow = new UserReadMoreWindow(otherUser);
            userReadMoreWindow.ShowDialog();
        }
    }
}
