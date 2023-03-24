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
using MeetMePlusWPF;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MeetMe_.ClientService;

namespace MeetMe_.Register
{
    /// <summary>
    /// Interaction logic for Name.xaml
    /// </summary>
    public partial class Name : Page
    {
        User newUser;
        public Name()
        {
            InitializeComponent();
            newUser = new User();
            birthdayDp.DisplayDateEnd=DateTime.Now.AddYears(-8);
            birthdayDp.DisplayDateStart = DateTime.Now.AddYears(-100);
            this.DataContext = newUser;
            newUser.ProfPicExt = "jpg";
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
            if (firstNameTb.Text == "" || lastNameTb.Text == "" || birthdayDp.Text == "")
            {
                MessageBox.Show("You must fill all fields", "Error");
                return;
            }
            int selectedYear = int.Parse(birthdayDp.Text.Split('/')[2]);
            if (2022- selectedYear > 100)
            {
                MessageBox.Show("Check your birth year... no one is that old", "Error");
                return;
            }
            if (2022 - selectedYear < 8)
            {
                MessageBox.Show("Sorry... Too young", "Error");
                return;
            }
            else
            {
                newUser.FirstName = firstNameTb.Text;
                newUser.LastName = lastNameTb.Text;
                newUser.Birthday = DateTime.Parse(birthdayDp.Text);
                Gender gender = new Gender(newUser);
                this.NavigationService.Navigate(gender);
            }
        }
    }
}
