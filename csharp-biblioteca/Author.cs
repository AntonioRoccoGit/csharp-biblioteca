using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Author
    {

        public Author(string name, string surname) {
            this.Name = name;
            this.Surname = surname;
        }
       
        //PROPERTIES
        public string Name { get; private set; }  
        public string Surname { get; private set; }
    }
}
