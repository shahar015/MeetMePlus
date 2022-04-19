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

namespace MeetMe_.MeetMePlus.MyAcc
{
    /// <summary>
    /// Interaction logic for ProfInfo.xaml
    /// </summary>
    public partial class ProfInfo : Page
    {
        User mainUser;
        MyAccount accountPage;
        User defaultUser;
        public ProfInfo()
        {
            InitializeComponent();
        }
        public ProfInfo(User user, MyAccount myAccPage)
        {
            InitializeComponent();
            usernameTb.Foreground = Brushes.White;
            usernameDot.Visibility = Visibility.Hidden;
            accountPage =myAccPage;
            mainUser = user;
            defaultUser = new User{Id=mainUser.Id, FirstName=mainUser.FirstName, LastName=mainUser.LastName, Birthday=mainUser.Birthday, Gender=mainUser.Gender, Email=mainUser.Email, Phone=mainUser.Phone, Username=mainUser.Username, Password=mainUser.Password, Interests=mainUser.Interests};
            //defaultUser = (User)mainUser.Clone() ;
            this.DataContext = mainUser;
            
        }
        public void EditMode()
        {
           usernameTb.IsEnabled = true;
            passwordTb.IsEnabled = true;
            emailTb.IsEnabled = true;
            interestsTb.IsEnabled = true;
        }
        public void Cancel()
        {
            mainUser = new User { Id = defaultUser.Id, FirstName = defaultUser.FirstName, LastName = defaultUser.LastName, Birthday = defaultUser.Birthday, Gender = defaultUser.Gender, Email = defaultUser.Email, Phone = defaultUser.Phone, Username = defaultUser.Username, Password = defaultUser.Password, Interests = defaultUser.Interests };
            this.DataContext = null;
            this.DataContext = mainUser;
            usernameTb.Foreground = Brushes.White;
            usernameDot.Visibility = Visibility.Hidden;
            usernameTb.IsEnabled = false;
            passwordTb.IsEnabled = false;
            emailTb.IsEnabled = false;
            interestsTb.IsEnabled = false;
        }
        public bool Save()
        {
            bool hasError = Validation.GetHasError(usernameTb) || Validation.GetHasError(passwordTb);
            if (hasError)
            {
                MessageBox.Show("Please check all fields", "Error");
                return hasError;
            }
            usernameTb.IsEnabled = false;
            usernameTb.Foreground = Brushes.White;
            usernameDot.Visibility = Visibility.Hidden;
            passwordTb.IsEnabled = false;
            emailTb.IsEnabled = false;
            interestsTb.IsEnabled = false;
            ServiceClient serviceClient = new ServiceClient();
            serviceClient.Users_Update(mainUser);
            return hasError;
        }

        private void usernameTb_LostFocus(object sender, RoutedEventArgs e)
        {
            MeetMe_.ClientService.ServiceClient serviceClient = new MeetMe_.ClientService.ServiceClient();
            User user = serviceClient.FindUsername(usernameTb.Text);
            if (user != null)
            {
                usernameDot.Foreground = Brushes.Red;
                usernameTb.Foreground = Brushes.Red;
                usernameDot.Visibility = Visibility.Visible;
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(usernameTb, "Hover red dot for more details");
                usernameDot.ToolTip = "•Username already exists";
                accountPage.saveBtn.IsEnabled = false;
            }
            else
            {
                usernameTb.Foreground = Brushes.LightGreen;
                usernameDot.Foreground = Brushes.Green;
                usernameDot.Visibility = Visibility.Visible;
                MaterialDesignThemes.Wpf.HintAssist.SetHelperText(usernameTb, "Hover green dot for more details");
                usernameDot.ToolTip = "•Good to go!";
                accountPage.saveBtn.IsEnabled = true;
            }
        }
    }
}
