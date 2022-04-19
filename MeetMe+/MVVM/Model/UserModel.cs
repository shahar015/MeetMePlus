using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMe_.MVVM.Model
{
    public class UserModel : BaseEntityModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
