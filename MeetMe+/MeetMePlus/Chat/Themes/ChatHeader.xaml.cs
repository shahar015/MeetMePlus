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

namespace MeetMe_.MeetMePlus.Chat.Themes
{
    /// <summary>
    /// Interaction logic for ChatHeader.xaml
    /// </summary>
    public partial class ChatHeader : UserControl
    {
        private User mainUser;
        private ClientService.Chat mainChat;

        public ChatHeader(User user, MeetMe_.ClientService.Chat chat)
        {
            InitializeComponent();
            mainUser = user;
            mainChat = chat;
            btnAll.Tag = this;
            LoadUserInfo();
        }

        public ChatHeader(User user)
        {
            InitializeComponent();
            mainUser = user;
            btnAll.Tag = this;
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            tbUserName.Text = mainUser.FirstName + " " + mainUser.LastName;
            tbUserInfo.Text = "@" + mainUser.Username;
            imgUser.ImageSource = ImageUtils.LoadProfPic(mainUser);
        }

        public MeetMe_.ClientService.Chat GetChat()
        {
            return mainChat;
        }

        public User GetUser()
        {
            return mainUser;
        }
    }
}
