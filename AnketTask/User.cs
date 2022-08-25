using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketTask
{
    public class User
    {
        public User(string name, string surname, string email, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Email { get; set; }
        public string PhoneNumber { get; set; }

        

    }
}
