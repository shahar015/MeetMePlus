using MeetMe_.ClientService;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MeetMe_
{

        public sealed class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                                object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            string fileName = (string)value;
            if (fileName == "") return null;
            DirectoryInfo dirInfo = new DirectoryInfo(ImageUtils.ImageDirectory);
            FileInfo[] info = dirInfo.GetFiles(fileName + ".*");
            string path="";
            try
            {
                path = Path.Combine(ImageUtils.ImageDirectory, info[0].FullName);
                if (!File.Exists(path))
                {
                    GetImageFromService(fileName, path);
                }
            }
            catch
            {
                path = Path.Combine(ImageUtils.ImageDirectory, "default.jpg");
            }
            // finally
            return new BitmapImage(new Uri(path));
        }

        private void GetImageFromService(string fileName, string localFilePath)
        {
            ServiceClient service = new ServiceClient();
            byte[] imageArray = service.GetIamge(fileName);
            MemoryStream stream = new MemoryStream(imageArray);
            System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
            img.Save(localFilePath);
        }        

        public object ConvertBack(object value, Type targetType,
                                    object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
