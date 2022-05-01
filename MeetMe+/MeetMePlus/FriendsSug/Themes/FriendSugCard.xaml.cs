using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Friends;
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

namespace MeetMe_.MeetMePlus.FriendsSug.Themes
{
    /// <summary>
    /// Interaction logic for FriendSugCard.xaml
    /// </summary>
    public partial class FriendSugCard : UserControl
    {
        User myUser;
        User mainUser;
        FriendsPage mainFriendsPage;
        List<string> mainCommonInterest;
        public FriendSugCard()
        {
            InitializeComponent();
        }
        public FriendSugCard(FriendsPage friendsPage, User user, User otherUser, List<string> commonInterest)
        {
            InitializeComponent();
            myUser = user;
            mainUser = otherUser;
            mainCommonInterest = commonInterest;
            mainFriendsPage = friendsPage;
            this.DataContext = otherUser;
            profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(otherUser);
            InterestsTb.Text = string.Join(", ", commonInterest);

        }

        private void AddFriendBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure you want to add friend?", "Add Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ServiceClient serviceClient = new ServiceClient();
                Friend friend = new Friend();
                friend.User1 = myUser;
                friend.User2 = mainUser;
                serviceClient.Friends_Insert(friend);
                mainFriendsPage.Load();
            }
        }
    }
}
