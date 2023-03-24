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
using System.Windows.Shapes;

namespace MeetMe_.MeetMePlus.Chat.Themes
{
    /// <summary>
    /// Interaction logic for NewChat.xaml
    /// </summary>
    public partial class NewChat : Window
    {
        FriendsList friends;
        FriendsList noChatFriends;
        private User otherUser;
        User mainUser;

        public NewChat(ChatsList chats, User user)
        {
            InitializeComponent();
            mainUser = user;
            LoadNoChatFriends(chats, user);
            LoadChatHeaders(noChatFriends);
        }

        private void LoadNoChatFriends(ChatsList chats, User user)
        {
            noChatFriends = new FriendsList();
            ServiceClient serviceClient = new ServiceClient();
            friends = serviceClient.Friend_SelectByUser(user);
            for (int i = 0; i < friends.Count; i++)
            {
                bool chatExist = false;
                User otherUser = friends[i].User1;
                if (otherUser.Id == user.Id)
                    otherUser = friends[i].User2;

                for (int b = 0; b < chats.Count; b++)
                {
                    if (otherUser.Id == chats[b].User1.Id || otherUser.Id == chats[b].User2.Id)
                    {
                        chatExist = true;
                    }
                }
                if (!chatExist)
                    noChatFriends.Add(friends[i]);
            }
        }

        private void LoadChatHeaders(FriendsList friends)
        {
            lvFriends.Items.Clear();
            for (int i = 0; i < friends.Count; i++)
            {
                User othenUser = friends[i].User1;
                if (mainUser.Id == othenUser.Id)
                    othenUser = friends[i].User2;
                ChatHeader ucc = new ChatHeader(othenUser);
                ucc.btnAll.Click += new RoutedEventHandler(this.ChatHeader_Click);
                lvFriends.Items.Add(ucc);
            }
        }

        private void ChatHeader_Click(object sender, RoutedEventArgs e)
        {
            ChatHeader ucc = (sender as Button).Tag as ChatHeader;
            if (ucc != null)
                otherUser = ucc.GetUser();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddChatBtn_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient client = new ServiceClient();
            ClientService.Chat chat = new ClientService.Chat();
            chat.User1 = mainUser;
            chat.User2 = otherUser;
            client.Chat_Insert(chat);
            this.Close();
        }
    }
}
