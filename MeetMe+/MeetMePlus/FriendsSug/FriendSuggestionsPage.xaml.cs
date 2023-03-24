using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Friends;
using MeetMe_.MeetMePlus.FriendsSug.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
            mainFriendsPage = friendsPage;
            mainUser = user;
            Load();

        }

        public void Load()
        {
            noSugTb.Visibility = Visibility.Hidden;
            usersLst.Children.Clear();
            ServiceClient serviceClient = new ServiceClient();
            UsersList users = serviceClient.User_SelectAllBesidesUser(mainUser);
            UsersList users1 = serviceClient.User_SelectAllBesidesUser(mainUser);
            FriendsList friends = serviceClient.Friend_SelectByUser(mainUser);
            foreach (User item in users)
            {
                foreach (Friend friend in friends)
                {
                    if (friend.User1.Id == item.Id || friend.User2.Id == item.Id)
                    {
                        users1.Remove(users1.Find(item1 => item1.Id == item.Id));
                    }
                }
            }
            var suggestionsList = new List<Tuple<User, List<string>>>();
            foreach (User user in users1)
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
                FriendSugCard friendsCard = new FriendSugCard(mainFriendsPage, mainUser, suggestion.Item1, suggestion.Item2, this);
                usersLst.Children.Add(friendsCard);
            }
            if (usersLst.Children.Count == 0)
                noSugTb.Visibility = Visibility.Visible;
            else
                noSugTb.Visibility = Visibility.Hidden;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            usersLst.Children.Clear();
            if (tbSearch.Text=="")
            {
                Load();
                return;
            }
            ServiceClient service = new ServiceClient();
            UsersList allUserList = service.User_Search(tbSearch.Text);
            foreach (User item in allUserList)
            {
                if (service.Friend_SelectByUsers(item, mainUser) == null && item.Id!=mainUser.Id)
                {
                    FriendSugCard friendsCard = new FriendSugCard(mainFriendsPage, mainUser, item, this);
                    usersLst.Children.Add(friendsCard);
                }
            }
            if (usersLst.Children.Count == 0)
                noResultTb.Visibility = Visibility.Visible;
            else
                noResultTb.Visibility = Visibility.Hidden;
        }
    }
}
