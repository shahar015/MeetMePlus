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

namespace MeetMe_.MeetMePlus.Chat.Themes
{
    /// <summary>
    /// Interaction logic for Message.xaml
    /// </summary>
    public partial class Message : UserControl
    {
        public Message(MeetMe_.ClientService.Message message, bool isSent)
        {
            InitializeComponent();
            tbText.Text = message.Content;
            tbWhen.Text =
                message.SendingTime.ToShortDateString()
                + " "
                + message.SendingTime.ToShortTimeString();
            var converter = new System.Windows.Media.BrushConverter();
            if (isSent)
            {
                var brush = (Brush)converter.ConvertFromString("#FF0067FB");
                border.Background = brush;
                border.HorizontalAlignment = HorizontalAlignment.Right;
                tbWhen.HorizontalAlignment = HorizontalAlignment.Right;
                border.CornerRadius = new CornerRadius(15, 15, 0, 15);
            }
            else
            {
                var brush = (Brush)converter.ConvertFromString("#FF009CFF");
                border.Background = brush;
                border.HorizontalAlignment = HorizontalAlignment.Left;
                tbWhen.HorizontalAlignment = HorizontalAlignment.Left;
                border.CornerRadius = new CornerRadius(15, 15, 15, 0);
            }
        }
    }
}
