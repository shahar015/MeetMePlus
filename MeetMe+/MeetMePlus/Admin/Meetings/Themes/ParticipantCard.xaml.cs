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

namespace MeetMe_.MeetMePlus.Admin.Meetings.Themes
{
    /// <summary>
    /// Interaction logic for ParticipantCard.xaml
    /// </summary>
    public partial class ParticipantCard : UserControl
    {
        User mainUser;
        ParticipentInMeeting mainPartcipentInMeeting;
        ParticipantsWindow mainParticipantsWindow;

        public ParticipantCard(
            ParticipentInMeeting partcipentInMeeting,
            User user,
            ParticipantsWindow participantsWindow
        )
        {
            InitializeComponent();
            mainUser = partcipentInMeeting.Participent;
            mainPartcipentInMeeting = partcipentInMeeting;
            mainParticipantsWindow = participantsWindow;
            LoadUserInfo();
            if (user.Id == partcipentInMeeting.Meeting.Creator.Id || user.UserType.Name == "Admin")
                RemoveBtn.Visibility = Visibility.Visible;
        }

        private void LoadUserInfo()
        {
            tbUserName.Text = mainUser.FirstName + " " + mainUser.LastName;
            tbUserInfo.Text = "@" + mainUser.Username;
            imgUser.ImageSource = ImageUtils.LoadProfPic(mainUser);
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(
                "Are you sure you want to remove participant form meeting?",
                "Delete Confirmation",
                System.Windows.MessageBoxButton.YesNo
            );
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ServiceClient serviceClient = new ServiceClient();
                serviceClient.ParticipentInMeeting_Delete(mainPartcipentInMeeting);
                mainParticipantsWindow.Load();
            }
        }

        private void userBtn_Click(object sender, RoutedEventArgs e)
        {
            UserReadMoreWindow userReadMoreWindow = new UserReadMoreWindow(mainUser);
            userReadMoreWindow.ShowDialog();
        }
    }
}
