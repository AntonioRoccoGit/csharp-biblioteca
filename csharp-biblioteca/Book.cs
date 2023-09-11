using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {

        private int _NumberPage;

        public Book(string idNumber, string title, string date, string genre) : base(idNumber, title, date, genre)
        {
        }

        //PROPERTIES
        public int NumberPage 
        {
            get { return this._NumberPage; }

            set
            {
                if (value > 0)
                    this._NumberPage = value;
            } 
        }


    }
}
