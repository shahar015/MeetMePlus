using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.Admin.Accounts.Themes;
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

namespace MeetMe_.MeetMePlus.Admin
{
    /// <summary>
    /// Interaction logic for AdminAccountsPage.xaml
    /// </summary>
    public partial class AdminAccountsPage : Page
    {
        User mainUser;
        public AdminAccountsPage(User user)
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
            foreach (User user in users)
            {
                AdminUserCard userCard = new AdminUserCard(user, this);
                usersLst.Children.Add(userCard);
            }
        }
    }
}
