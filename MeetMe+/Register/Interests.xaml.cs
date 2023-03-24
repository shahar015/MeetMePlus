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
using MeetMe_.ClientService;
using MeetMePlusWPF;

namespace MeetMe_.Register
{
    /// <summary>
    /// Interaction logic for Interests.xaml
    /// </summary>
    public partial class Interests : Page
    {
        private User newUser;

        public Interests(User user)
        {
            InitializeComponent();
            List<string> hobbiesList = new List<string>()
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
            hobbiesLst.ItemsSource = hobbiesList;
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
            string[] selectedHobbies = hobbiesLst.SelectedItems.Cast<string>().ToArray();
            if (selectedHobbies.Length < 2)
            {
                MessageBox.Show("You must select at least 2 hobbies", "Error");
            }
            else
            {
                newUser.Interests = selectedHobbies;
                Final final = new Final(newUser);
                this.NavigationService.Navigate(final);
            }
        }
    }
}
