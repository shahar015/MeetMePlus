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
    /// Interaction logic for UserInfo.xaml
    /// </summary>
    public partial class UserInfo : Page
    {
        User mainUser;
        User defaultUser;
        public UserInfo()
        {
            InitializeComponent();
        }

        public UserInfo(User user)
        {
            InitializeComponent();
            mainUser = user;
            defaultUser = new User { Id = mainUser.Id, FirstName = mainUser.FirstName, LastName = mainUser.LastName, Birthday = mainUser.Birthday, Gender = mainUser.Gender, Email = mainUser.Email, Phone = mainUser.Phone, Username = mainUser.Username, Password = mainUser.Password, Interests = mainUser.Interests };
            this.DataContext = mainUser;
            bDayTb.Text = mainUser.Birthday.ToShortDateString();
            MaleRb.IsChecked = mainUser.Gender;
            FemaleRb.IsChecked = !mainUser.Gender;
        }
        public void EditMode()
        {
            firstNameTb.IsEnabled = true;
            lastNameTb.IsEnabled = true;
            MaleRb.IsEnabled = true;
            FemaleRb.IsEnabled = true;
        }
        public void Cancel()
        {
            mainUser = new User { Id = defaultUser.Id, FirstName = defaultUser.FirstName, LastName = defaultUser.LastName, Birthday = defaultUser.Birthday, Gender = defaultUser.Gender, Email = defaultUser.Email, Phone = defaultUser.Phone, Username = defaultUser.Username, Password = defaultUser.Password, Interests = defaultUser.Interests };
            this.DataContext = null;
            this.DataContext = mainUser;
            bDayTb.Text = mainUser.Birthday.ToShortDateString();
            MaleRb.IsChecked = mainUser.Gender;
            FemaleRb.IsChecked = !mainUser.Gender;
            firstNameTb.IsEnabled = false;
            lastNameTb.IsEnabled = false;
            bDayTb.IsEnabled = false;
            MaleRb.IsEnabled = false;
            FemaleRb.IsEnabled = false;
        }
        public bool Save()
        {
            bool hasError = Validation.GetHasError(firstNameTb) && Validation.GetHasError(lastNameTb);
            if (hasError)
            {
                MessageBox.Show("Please check all fields", "Error");
                return hasError;
            }
            mainUser.Birthday = DateTime.Parse(bDayTb.Text);
            mainUser.Gender = (bool)MaleRb.IsChecked;
            firstNameTb.IsEnabled = false;
            lastNameTb.IsEnabled = false;
            bDayTb.IsEnabled = false;
            MaleRb.IsEnabled = false;
            FemaleRb.IsEnabled = false;
            ServiceClient serviceClient = new ServiceClient();
            serviceClient.Users_Update(mainUser);
            return hasError;
        }
    }


}
