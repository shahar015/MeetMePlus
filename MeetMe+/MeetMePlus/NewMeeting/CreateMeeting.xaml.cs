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

namespace MeetMe_.MeetMePlus.NewMeeting
{
    /// <summary>
    /// Interaction logic for CreateMeeting.xaml
    /// </summary>
    public partial class CreateMeeting : Page
    {
        public CreateMeeting()
        {
            InitializeComponent();
        }
        public CreateMeeting(MeetMePlus meetMePlus,User user)
        {
            InitializeComponent();
            CreateMeetingFrame.Navigate(new NewMeetingStart(meetMePlus, user));
        }
    }
}
