using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MeetMePlusWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string Path(string folders)
        {
            string s = Environment.CurrentDirectory; //המיקום שבו רץ הפרויקט
            string[] sub = s.Split('\\'); //פירוק מחרוזת הכתובת למערך לפי תיקיות

            int index = sub.Length - 2; //חזרה אחורה 3 תיקיות
            sub[index] = folders;     //שינוי התיקיה לתיקיה המתאימה
            Array.Resize(ref sub, index + 1); //תיקון של אורך המערך, לאורך המתאים לתיקייה

            s = String.Join("\\", sub);  //חיבור מחדש של המערך עם / מפריד אישי 
            return s;
        }
    }
    
}
