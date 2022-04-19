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
using MeetMePlusWPF;
using System.Windows.Shapes;
using Microsoft.Win32;
using MeetMe_.ClientService;
using System.IO;
using System.Globalization;

namespace MeetMe_.Register
{
    /// <summary>
    /// Interaction logic for Final.xaml
    /// </summary>
    public partial class Final : Page
    {
        User newUser;
        ServiceClient serviceClient;
        string imagePath;
        public Final()
        {
            InitializeComponent();
        }

        public Final(User user)
        {
            InitializeComponent();

            newUser = user;
            serviceClient = new ServiceClient();
        }

        private void finishBt_Click(object sender, RoutedEventArgs e)
        {
            if (usernameTb.Text == "" || passwordPb.Password == "" || interestsTb.Text == "")
            {
                MessageBox.Show("You must fill all fields", "Error");
            }
            else
            {
                newUser.Username = usernameTb.Text;
                newUser.Password = passwordPb.Password;
                newUser.Interests = interestsTb.Text;
                serviceClient.Users_Insert(newUser);
                ImageUtils.SendImageToService(imagePath);
                //serviceClient.ImgPath(imagePath, @"Images\ProfPix\");
                Login login = new Login(newUser);
                login.Show();
                var wnd = Window.GetWindow(this) as Window;
                wnd.Close();
            }
        }

        private void cancelBt_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            var thisWin = Window.GetWindow(this);
            thisWin.Close();
        }

        private void usernameTb_LostFocus(object sender, RoutedEventArgs e)
        {
            User user = serviceClient.FindUsername(usernameTb.Text);
            if (user != null)
            {
                usernameDot.Foreground = Brushes.Red;
                usernameTb.Foreground = Brushes.Red;
                usernameDot.Visibility = Visibility.Visible;
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(usernameTb, "Hover red dot for more details");
                usernameDot.ToolTip = "•Username already exists";
            }
            else
            {
                usernameTb.Foreground = Brushes.LightGreen;
                usernameDot.Foreground = Brushes.Green;
                usernameDot.Visibility = Visibility.Visible;
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(usernameTb, "Hover green dot for more details");
                usernameDot.ToolTip = "•Good to go!";
            }
            finishBt.IsEnabled = user == null;
        }

        private void ProfPicBt_Click(object sender, RoutedEventArgs e)
        {
            if (usernameTb.Text == "")
            {
                MessageBox.Show("Must choose username first", "Error");
                return;
            }


            newUser.Username = usernameTb.Text;
            imagePath = ImageUtils.UploadImage_Dialog(newUser.Username);
            profPicWpf.ImageSource = (BitmapImage)ImageUtils.LoadPic(imagePath);
            newUser.ProfPicExt = System.IO.Path.GetExtension(imagePath);
        }
    }

}
