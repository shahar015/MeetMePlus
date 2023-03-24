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

namespace MeetMe_.MeetMePlus.FriendsSug.Themes
{
    /// <summary>
    /// Interaction logic for UserReadMoreWindow.xaml
    /// </summary>
    public partial class UserReadMoreWindow : Window
    {
        public UserReadMoreWindow(User user)
        {
            InitializeComponent();
            this.DataContext = user;
            bDayTb.Text = user.Birthday.ToShortDateString();
            genderTb.Text = "Male";
            if (!user.Gender)
                genderTb.Text = "Female";
            interestsTb.Text = string.Join(", ", user.Interests);
            profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(user);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
