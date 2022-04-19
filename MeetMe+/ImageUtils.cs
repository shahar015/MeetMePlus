using MeetMe_.ClientService;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MeetMe_
{
    public class ImageUtils
    {
        private static string imageDirectory;
        public static string ImageDirectory { get => imageDirectory; set => imageDirectory = value; }

        public static string UploadImage_Dialog(string username)
        {

            string filename = null;
            // Create OpenFileDialog 
            OpenFileDialog dlg = new OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.Filter = "All Images | *.jpg;*.jpeg;*.tif;*.tiff;*.bmp;*.png|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                filename = dlg.FileName;
                filename = SaveImageToClient(filename, username); // save the Picture in LocalFolder
                                                        // (if not exist) rns return only the file name
            }
            return filename;
        }

        public static string UpdateImage_Dialog(User user)
        {

            string filename = null;
            // Create OpenFileDialog 
            OpenFileDialog dlg = new OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.Filter = "All Images | *.jpg;*.jpeg;*.tif;*.tiff;*.bmp;*.png|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                filename = dlg.FileName;
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                DeleteImageFromClient(user);
                DeleteImageFromService(user);
                filename = SaveImageToClient(filename, user.Username);
                SendImageToService(filename);            
            }
            return filename;
        }

        public static string SaveImageToClient(string sourcefileName, string username)
        {
            string fileName = username + Path.GetExtension(sourcefileName);
            string localFilePath = System.IO.Path.Combine(imageDirectory, fileName);

            if (!File.Exists(localFilePath))
            {
                byte[] imgArray = File.ReadAllBytes(sourcefileName);
                var stream = new MemoryStream(imgArray);
                System.Drawing.Image img = System.Drawing.Image.FromStream(stream);

                img.Save(localFilePath);
            }
            return fileName;
        }

        public static void DeleteImageFromClient(User user)
        {
            string fileName = user.Username + user.ProfPicExt;
            string localFilePath = System.IO.Path.Combine(imageDirectory, fileName);
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            if (File.Exists(localFilePath))
            {
                File.Delete(localFilePath);
            }


        }

        public static void SendImageToService(string image)
        {
            string path = System.IO.Path.Combine(imageDirectory, image);
            byte[] imgArray = File.ReadAllBytes(path);

            ServiceClient service = new ServiceClient();
            service.SaveImage(imgArray, image);
        }

        public static void DeleteImageFromService(User user)
        {
            ServiceClient service = new ServiceClient();
            string fileName = user.Username + user.ProfPicExt;
            service.DeleteImage(fileName);
        }

        public static BitmapImage LoadProfPic(User user)
        {
            string path = System.IO.Path.Combine(ImageUtils.ImageDirectory, user.Username + user.ProfPicExt);
            if (!File.Exists(path))
            {
                path = System.IO.Path.Combine(ImageUtils.ImageDirectory, "default.jpg");
            }
            using (var stream = new FileStream(path, FileMode.Open))
            {
                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
                bitmapImage.Freeze();
                return bitmapImage;
            }
        }

        public static BitmapImage LoadPic(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open))
            {
                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
                bitmapImage.Freeze();
                return bitmapImage;
            }
        }

    }
}
