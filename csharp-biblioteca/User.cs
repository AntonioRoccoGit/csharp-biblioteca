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
        private string name;
        private string surname;
        private string email;
        private string password;
        private string telephoneNumber;

        public User(string name, string surname, string email, string password, string telephoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
            this.telephoneNumber = telephoneNumber;
        }

        //PROPERTY
        public string Name
        {
            get { return this.name; }
            
        }
        public string Surname
        { 
            get { return this.surname;}
        }

        public string Email
        {
            get { return this.email; }
        }

        public string Password
        {
            get { return this.password; }
        }

        public string TelephoneNumber
        {
            get { return this.telephoneNumber; }
        }
    }
}
