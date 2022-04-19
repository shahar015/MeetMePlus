using MeetMe_.ClientService;
using MeetMe_.MeetMePlus.MyAcc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace MeetMe_.MeetMePlus
{
    /// <summary>
    /// Interaction logic for MyAccount.xaml
    /// </summary>
    public partial class MyAccount : Page
    {
        User mainUser;
        UserInfo userInfoPage;
        ProfInfo profInfoPage;
        string imagePath;
        int page;
        public MyAccount(User user)
        {
            InitializeComponent();
            mainUser = user;
            userInfoPage = new UserInfo(user);
            profInfoPage = new ProfInfo(user,this);
            infoFrame.Navigate(userInfoPage);
            page = 1;
            profPic.ImageSource = (BitmapImage)ImageUtils.LoadProfPic(mainUser);
        }


        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (page == 1)
            {
                bool error= userInfoPage.Save();
                if (error)
                    return;
            }

            if (page == 2)
            {
                bool error = profInfoPage.Save();
                if (error)
                    return;
            }
            editBtnsPanel.Visibility = Visibility.Hidden;
            infoSwitchPanel.Visibility = Visibility.Visible;
           
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            editBtnsPanel.Visibility = Visibility.Hidden;
            infoSwitchPanel.Visibility = Visibility.Visible;
            if (page == 1)
                userInfoPage.Cancel();
            if (page == 2)
                profInfoPage.Cancel();
        }

        private void ProfInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            infoFrame.Navigate(profInfoPage);
            page = 2;
        }

        private void UserInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            infoFrame.Navigate(userInfoPage);
            page = 1;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            editBtnsPanel.Visibility = Visibility.Visible;
            infoSwitchPanel.Visibility = Visibility.Hidden;
            if (page == 1)
                userInfoPage.EditMode();
            if (page == 2)
                profInfoPage.EditMode();
        }

        private void EditImgBtn_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient serviceClient = new ServiceClient();
            profPic.ImageSource = null;
            imagePath = ImageUtils.UpdateImage_Dialog(mainUser);
            ImageConverter imageConverter = new ImageConverter();
            profPic.ImageSource = (ImageSource)imageConverter.Convert(imagePath,
                null, null, CultureInfo.CurrentCulture);
            mainUser.ProfPicExt = System.IO.Path.GetExtension(imagePath);
            serviceClient.Users_Update(mainUser);
        }
    }
}
