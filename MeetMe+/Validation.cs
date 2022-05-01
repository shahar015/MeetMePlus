using MeetMe_.ClientService;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MeetMe_
{
    public class ValidFirstName : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                string name = value.ToString();
                if(name.Length<2)
                    return new ValidationResult(false, "Minimum of 2 characters");
                if (name.Length > 20)
                    return new ValidationResult(false, "Maximum of 20 characters");
                for (int i = 0; i < name.Length; i++)
                {
                    if (!Char.IsLetter(name[i])& !Char.IsWhiteSpace(name[i]) & name[i]!='-')
                        return new ValidationResult(false, "Only letters and some special charecters: -");
                }
            }
            catch (Exception)
            {
                return new ValidationResult(false, "Invalid charecters");
            }
            return ValidationResult.ValidResult;
        }
    }

    public class ValidUsername : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                string username = value.ToString();
                if (username.Length < 5)
                    return new ValidationResult(false, "Minimum of 5 characters");
                if (username.Length > 25)
                    return new ValidationResult(false, "Maximum of 25 characters");
                for (int i = 0; i < username.Length; i++)
                {
                    if (!Char.IsLetterOrDigit(username[i]) && !Char.IsWhiteSpace(username[i]) && username[i] != '_' && username[i] != '.')
                        return new ValidationResult(false, "Only letters, numbers and some special charecters: _ , .");
                }
                ServiceClient serviceClient = new ServiceClient();
                User user = serviceClient.User_FindUsername(username);
                if (user != null)
                    return new ValidationResult(false, "username already exists");
            }
            catch (Exception )
            {
                return new ValidationResult(false, "Invalid charecters");
            }
            return ValidationResult.ValidResult;
        }
    }

    public class ValidPassword : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            bool isUpper=false;
            bool isLower=false;
            bool isNum=false;
            try
            {
                string password = value.ToString();
                if (password.Length < 8)
                    return new ValidationResult(false, "Minimum of 8 characters");
                if (password.Length > 20)
                    return new ValidationResult(false, "Maximum of 20 characters");
                for (int i = 0; i < password.Length; i++)
                {
                    if (!Char.IsLetter(password[i]) || !Char.IsWhiteSpace(password[i]) || !Char.IsNumber(password[i]) || password[i] != '!' || password[i] != '@' || password[i] != '.' || password[i] != '&')
                        return new ValidationResult(false, "Only letters, numbers and some special charecters: !, . , @ , &");
                    if (Char.IsUpper(password[i]))
                        isUpper = true;
                    if (Char.IsLower(password[i]))
                        isLower = true;
                    if (Char.IsNumber(password[i]))
                        isNum = true;
                }
                if (!isUpper)
                    return new ValidationResult(false, "Must include at least 1 upper letter");
                if (!isLower)
                    return new ValidationResult(false, "Must include at least 1 lower letter");
                if (!isNum)
                    return new ValidationResult(false, "Must include at least 1 number");
            }
            catch (Exception)
            {
                return new ValidationResult(false, "Invalid charecters");
            }
            return ValidationResult.ValidResult;
        }
    }

    public class ValidEmail : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                string email = value.ToString();
                if(email.Length<6)
                    return new ValidationResult(false, "Invalid email");
                if (email.Length >255)
                    return new ValidationResult(false, "Invalid email");
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                return new ValidationResult(false, "Invalid email");
            }
            return ValidationResult.ValidResult;
        }
    }

    public class ValidBdate : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                DateTime dt=DateTime.Parse(value.ToString());
                if (dt.CompareTo(DateTime.Today.AddYears(-10))>=0)
                    return new ValidationResult(false, "too young");
            }
            catch (FormatException)
            {
                return new ValidationResult(false, "Invalid b-Day");
            }
            return ValidationResult.ValidResult;
        }
    }

    public class ValidPhone : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                string phone = value.ToString();
                if (phone.Length < 10 || phone.Length>10)
                    return new ValidationResult(false, "Must be 10 numbers");
              
                for (int i = 0; i < phone.Length; i++)
                {
                    if (!Char.IsNumber(phone[i]))
                        return new ValidationResult(false, "Only numbers");
                }
            }
            catch (Exception)
            {
                return new ValidationResult(false, "Invalid charecters");
            }
            return ValidationResult.ValidResult;
        }
    }
}
