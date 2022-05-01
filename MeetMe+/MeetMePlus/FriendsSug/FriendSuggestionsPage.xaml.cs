using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Friends;
using MeetMe_.MeetMePlus.FriendsSug.Themes;
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

namespace MeetMe_.MeetMePlus.FriendsSug
{
    /// <summary>
    /// Interaction logic for FriendSuggestionsPage.xaml
    /// </summary>
    public partial class FriendSuggestionsPage : Page
    {
        User mainUser;
        FriendsPage mainFriendsPage;

        public FriendSuggestionsPage()
        {
            InitializeComponent();
        }

        public FriendSuggestionsPage(User user, FriendsPage friendsPage)
        {
            InitializeComponent();
            mainUser = user;
            Load();
        }

        public void Load()
        {
            usersLst.Children.Clear();
            ServiceClient serviceClient = new ServiceClient();
            UsersList users = serviceClient.User_SelectAllBesidesUser(mainUser);
            var suggestionsList = new List<Tuple<User, List<string>>>();
            foreach (User user in users)
            {
                List<string> interestsLst = new List<string>();
                for (int i = 0; i < mainUser.Interests.Length; i++)
                {
                    if (user.Interests.ToList().Exists(item => item == mainUser.Interests[i]))
                    {
                        interestsLst.Add(mainUser.Interests[i]);
                    }
                }
                if (interestsLst.Count > 1)
                {
                    suggestionsList.Add(new Tuple<User, List<string>>(user, interestsLst));
                }
            }
            foreach (Tuple<User, List<string>> suggestion in suggestionsList)
            {
                FriendSugCard friendsCard = new FriendSugCard(mainFriendsPage, mainUser, suggestion.Item1, suggestion.Item2);
                usersLst.Children.Add(friendsCard);
            }
        }
    }
}
