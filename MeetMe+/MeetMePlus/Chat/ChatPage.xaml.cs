using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Chat.Themes;
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

namespace MeetMe_.MeetMePlus.Chat
{
    /// <summary>
    /// Interaction logic for Chat.xaml
    /// </summary>
    /// 

    public partial class ChatPage : Page
    {
        private User myUser;
        private MeetMe_.ClientService.Chat currentChat;
        private User otherUser;
        private ServiceClient service;
        private ChatsList activeChats;

        public ChatPage()
        {
            InitializeComponent();
        }

        public ChatPage(User user)
        {
            InitializeComponent();
            myUser = user;
            this.DataContext = user;
            service = new ServiceClient();
            activeChats = service.Chat_SelectByUser(myUser);
            LoadChatHeaders(activeChats);
        }

        public void LoadChatHeaders(ChatsList chats)
        {
            lvChats.Items.Clear();
            for (int i = 0; i < chats.Count; i++)
            {
                User othenUser = chats[i].User1;
                if (myUser.Id == othenUser.Id)
                    othenUser = chats[i].User2;
               ChatHeader ucc = new ChatHeader(othenUser, chats[i]);
                ucc.btnAll.Click += new RoutedEventHandler(this.ChatHeader_Click);
                lvChats.Items.Add(ucc);
            }
        }
        private void ChatHeader_Click(object sender, RoutedEventArgs e)
        {
            ChatHeader ucc = (sender as Button).Tag as ChatHeader;
            if (ucc != null)
            otherUser = ucc.GetUser();
            currentChat = ucc.GetChat();
            ChatTitle.Children.Clear();
            ChatTitle.Children.Add(new ChatHeader(otherUser));
            messageSendArea.Visibility = Visibility.Visible;
            LoadChatText();
        }
        private void LoadChatText()
        {
            currentChat = currentChat == null ? CreateNewChat() : currentChat;
            MessagesList messages = service.Message_SelectByChat(currentChat);
            messages.Sort((x, y) => DateTime.Compare(x.SendingTime, y.SendingTime));

            ViewMessages.Children.Clear();
            foreach (ClientService.Message message in messages)
            {
                MeetMe_.MeetMePlus.Chat.Themes.Message ucms = new MeetMe_.MeetMePlus.Chat.Themes.Message(message, message.Sender.Id == myUser.Id);
                ucms.Width = Double.NaN;
                ViewMessages.Children.Add(ucms);
            }
            chatScrollViewer.ScrollToBottom();
        }
        public void LoadChatTextFriends(ClientService.Chat friendChat)
        {
            otherUser = friendChat.User1;
            if (friendChat.User1.Id==myUser.Id)
                otherUser = friendChat.User2;
            MessagesList messages = service.Message_SelectByChat(friendChat);
            messages.Sort((x, y) => DateTime.Compare(x.SendingTime, y.SendingTime));
            ChatTitle.Children.Clear();
            ChatTitle.Children.Add(new ChatHeader(otherUser));
            ViewMessages.Children.Clear();
            foreach (ClientService.Message message in messages)
            {
                MeetMe_.MeetMePlus.Chat.Themes.Message ucms = new MeetMe_.MeetMePlus.Chat.Themes.Message(message, message.Sender.Id == myUser.Id);
                ucms.Width = Double.NaN;
                ViewMessages.Children.Add(ucms);
            }
            messageSendArea.Visibility = Visibility.Visible;
            chatScrollViewer.ScrollToBottom();
        }
        private ClientService.Chat CreateNewChat()
        {
            currentChat = new ClientService.Chat { User1 = myUser, User2 = otherUser };
            service.Chat_Insert(currentChat);
            return service.Chat_SelectByUsers(myUser, otherUser);
        }      
        private void btnMyChats_Click(object sender, RoutedEventArgs e)
        {
            tbSearch.Text = string.Empty;
            LoadChatHeaders(activeChats);
        }

        private void btnAddMessage_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient service = new ServiceClient();
            if (tbChatText.Text.Length > 0)
            {
                currentChat = currentChat == null ? CreateNewChat() : currentChat;
                ClientService.Message message = new ClientService.Message { Chat= currentChat, Sender = myUser, Content = tbChatText.Text, SendingTime = DateTime.Now };
                service.Message_Insert(message);
                LoadChatText();
            }
            tbChatText.Text = "";
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            lvChats.Items.Clear();
            UsersList allUserList = service.User_Search(tbSearch.Text);
            foreach (User item in allUserList)
            {
                ClientService.Chat chat = service.Chat_SelectByUsers(item, myUser);
                ChatHeader ucc = new ChatHeader(item, chat);
                lvChats.Items.Add(ucc);
            }

        }

        private void btnNewChat_Click(object sender, RoutedEventArgs e)
        {
            NewChat newChat = new NewChat(activeChats, myUser);
            newChat.ShowDialog();
            activeChats = service.Chat_SelectByUser(myUser);
            LoadChatHeaders(activeChats);
        }
    }
}
