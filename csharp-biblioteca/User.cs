using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        //ATTRIBUTE
        public User(string name, string surname, string email, string password, string telephoneNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.TelephoneNumber = telephoneNumber;
        }

        //PROPERTIES
        public string Name { get; }
        public string Surname { get; }
        public string Email{get;}
        public string Password { get; }
        public string TelephoneNumber { get; }
    }
}
