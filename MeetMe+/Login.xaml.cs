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
using MeetMe_.ClientService;
using MeetMe_.MeetMePlus;

namespace MeetMePlusWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            usernameTb.Text = MeetMe_.Properties.Settings.Default.username;
            passwordTb.Password = MeetMe_.Properties.Settings.Default.password;
        }

        public Login(User user)
        {
            InitializeComponent();
            usernameTb.Text = user.Username;
            passwordTb.Password = user.Password;
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Button_Click_1(sender, e);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win=new MainWindow();
            
            win.Show();
            this.Close();
        }

        void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (usernameTb.Text == "" || passwordTb.Password == "")
            {
                MessageBox.Show("You must fill all fields", "Error");
            }
            else
            {
                MeetMe_.ClientService.ServiceClient serviceClient = new MeetMe_.ClientService.ServiceClient();
                User user = serviceClient.User_SelectLogin(usernameTb.Text, passwordTb.Password);
                if (user != null)
                {
                    if (rememberCb.IsChecked == true)
                    {
                        MeetMe_.Properties.Settings.Default.username = usernameTb.Text;
                        MeetMe_.Properties.Settings.Default.password = passwordTb.Password;
                        MeetMe_.Properties.Settings.Default.Save();
                    }
                    MeetMePlus meetMePlus = new MeetMePlus(user);
                    meetMePlus.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("wrong username or password", "Error");
                }
            }
            
        }
    }
}
