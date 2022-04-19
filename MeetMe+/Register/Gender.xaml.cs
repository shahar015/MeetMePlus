using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MeetMePlusWPF;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MeetMe_.ClientService;

namespace MeetMe_.Register
{
    /// <summary>
    /// Interaction logic for Gender.xaml
    /// </summary>
    public partial class Gender : Page
    {
        User newUser;
        public Gender()
        {
            InitializeComponent();
        }

        public Gender(User user)
        {
            InitializeComponent();
            newUser = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            var thisWin = Window.GetWindow(this);
            thisWin.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (maleRb.IsChecked == true)
            {
                newUser.Gender = true;
                this.NavigationService.Navigate(new ContactDetailes(newUser));
            }
            else if (femaleRb.IsChecked == true)
            {
                newUser.Gender = false;
                this.NavigationService.Navigate(new ContactDetailes(newUser));
            }
            else
                MessageBox.Show("Must choose gender", "Error");
            
        }
    }
}
