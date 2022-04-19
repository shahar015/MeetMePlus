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
using MeetMePlusWPF;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MeetMe_.ClientService;

namespace MeetMe_.Register
{
    /// <summary>
    /// Interaction logic for ContactDetailes.xaml
    /// </summary>
    public partial class ContactDetailes : Page
    {
        User newUser;
        public ContactDetailes()
        {
            InitializeComponent();
            
        }

        public ContactDetailes(User user)
        {
            InitializeComponent();

            newUser = user;
            this.DataContext = newUser;
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
            if (emailTb.Text == "" || phoneTb.Text == "")
            {
                MessageBox.Show("You must fill all fields", "Error");
            }
            else
            {
                newUser.Email = emailTb.Text;
                newUser.Phone = phoneTb.Text;

                Final final = new Final(newUser);
                this.NavigationService.Navigate(final);
            }
            
        }
    }
}
