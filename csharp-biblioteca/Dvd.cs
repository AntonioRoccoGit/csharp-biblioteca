using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        private int _Duration;

        public Dvd(string idNumber, string title, string date, string genre) : base(idNumber, title,date, genre)
        {

        }


        //PROPERTIES
        public int Duration
        {
            get { return this._Duration; }

            set
            {
                if (value > 0)
                    this._Duration = value;
            }
        }

    }
}
