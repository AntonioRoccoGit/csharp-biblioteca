using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Author
    {
        //ATTRIBUTE
        private string name;
        private string surname;


        public Author(string name, string surname) {
            this.name = name;
            this.surname = surname;
        }
       
        //PROPERTIES
        public string Name { get { return this.name; } }
        public string Surname { get { return this.surname; } }
    }
}
