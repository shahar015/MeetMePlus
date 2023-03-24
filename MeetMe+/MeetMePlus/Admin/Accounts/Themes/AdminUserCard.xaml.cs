using MeetMe_.ClientService;
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

namespace MeetMe_.MeetMePlus.Admin.Accounts.Themes
{
    /// <summary>
    /// Interaction logic for AdminUserCard.xaml
    /// </summary>
    public partial class AdminUserCard : UserControl
    {
        User mainUser;
        AdminAccountsPage page;
        public AdminUserCard(User user, AdminAccountsPage adminAccountsPage)
        {
            InitializeComponent();
            this.DataContext = user;
            profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(user);
            page = adminAccountsPage;
            mainUser = user;
            if (user.UserType.Name=="Admin")
            {
                regUserBtn.Visibility = Visibility.Visible;
                adminUserBtn.Visibility = Visibility.Visible;
            }
        }

        private void deleteUserBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(
                "Are you sure you want to delete user?",
                "Add Confirmation",
                System.Windows.MessageBoxButton.YesNo
            );
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ServiceClient serviceClient = new ServiceClient();
                serviceClient.ParticipentsInMeeting_DeleteByUser(mainUser);
                serviceClient.Friends_DeleteByUser(mainUser);
                MeetingsList meetings= serviceClient.Meetings_SelectByUser(mainUser);
                foreach (Meeting item in meetings)
                {
                    serviceClient.ParticipentsInMeeting_DeleteByMeeting(item);
                    serviceClient.Meetings_Delete(item);
                }
                serviceClient.Messages_DeleteByUser(mainUser);
                ChatsList chats= serviceClient.Chat_SelectByUser(mainUser);
                foreach  (ClientService.Chat item in chats)
                {
                    serviceClient.Message_DeleteFromChat(item);
                    serviceClient.Chat_Delete(item);
                }
                serviceClient.Users_Delete(mainUser);
                ImageUtils.DeleteImageFromClient(mainUser);
                ImageUtils.DeleteImageFromService(mainUser);
                page.Load();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserReadMoreWindow userReadMoreWindow = new UserReadMoreWindow(mainUser);
            userReadMoreWindow.ShowDialog();
        }

        private void MakeAdminBtn_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient serviceClient= new ServiceClient();
            UserTypesList userTypes = serviceClient.UserTypes_SelectAll();
            mainUser.UserType = userTypes[0];
            serviceClient.Users_Update(mainUser);
            page.Load();
        }
        private void MakeRegularBtn_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient serviceClient = new ServiceClient();
            UserTypesList userTypes = serviceClient.UserTypes_SelectAll();
            mainUser.UserType = userTypes[1];
            serviceClient.Users_Update(mainUser);
            page.Load();
        }
    }
}
