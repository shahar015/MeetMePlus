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
        string[] mainHobbiesList;
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
            defaultUser = new User{Id=mainUser.Id, FirstName=mainUser.FirstName, LastName=mainUser.LastName, Birthday=mainUser.Birthday, Gender=mainUser.Gender, Email=mainUser.Email, Phone=mainUser.Phone, Username=mainUser.Username, Password=mainUser.Password, Interests=mainUser.Interests, UserType = mainUser.UserType, ProfPicExt = mainUser.ProfPicExt };
            string[] hobbiesList = new string[]
            {
                "Reading",
                "Traveling",
                "Fishing",
                "Crafting",
                "Watching TV",
                "Bird Watching",
                "Listening to music",
                "Gardening",
                "Video Games",
                "Yoga",
                "Hiking",
                "Cooking"
            };
            mainHobbiesList = hobbiesList; 
            hobbiesLst.ItemsSource = hobbiesList;
            this.DataContext = mainUser;
            LoadInterests();


        }
        
        public void LoadInterests()
        {
            for (int i = 0; i < mainHobbiesList.Length; i++)
            {
                if (Array.Exists(mainUser.Interests, item => item == mainHobbiesList[i]))
                {
                    hobbiesLst.SelectedItems.Add(mainHobbiesList[i]);
                }
            }
        }

        public void AddInterests()
        {
            string[] selectedHobbies = hobbiesLst.SelectedItems.Cast<string>().ToArray();
            if (selectedHobbies.Length < 2)
            {
                MessageBox.Show("You must select at least 2 hobbies", "Error");
            }
            else
            {
                mainUser.Interests = selectedHobbies;
            }
        }
        public void EditMode()
        {
           usernameTb.IsEnabled = true;
            passwordTb.IsEnabled = true;
            emailTb.IsEnabled = true;
            hobbiesLst.IsEnabled = true;
        }
        public void Cancel()
        {
            mainUser = new User { Id = defaultUser.Id, FirstName = defaultUser.FirstName, LastName = defaultUser.LastName, Birthday = defaultUser.Birthday, Gender = defaultUser.Gender, Email = defaultUser.Email, Phone = defaultUser.Phone, Username = defaultUser.Username, Password = defaultUser.Password, Interests = defaultUser.Interests, UserType = defaultUser.UserType, ProfPicExt = defaultUser.ProfPicExt };
            this.DataContext = null;
            this.DataContext = mainUser;
            LoadInterests();
            usernameTb.Foreground = Brushes.White;
            usernameDot.Visibility = Visibility.Hidden;
            usernameTb.IsEnabled = false;
            passwordTb.IsEnabled = false;
            emailTb.IsEnabled = false;
            hobbiesLst.IsEnabled = false;
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
            hobbiesLst.IsEnabled = false;
            AddInterests();
            ServiceClient serviceClient = new ServiceClient();
            serviceClient.Users_Update(mainUser);
            return hasError;
        }

        private void usernameTb_LostFocus(object sender, RoutedEventArgs e)
        {
            MeetMe_.ClientService.ServiceClient serviceClient = new MeetMe_.ClientService.ServiceClient();
            User user = serviceClient.User_FindUsername(usernameTb.Text);
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
