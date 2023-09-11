using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Borrowed
    {




        public string UserName { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; set; }

       
        /// <param name="userName"> Indicate only the user name </param>
        /// <param name="manyDay"> Indicate the duration expressed in days </param>
        public Borrowed(string userName, int manyDay)
        {
            this.UserName = userName;

            DateTime now = DateTime.Now;
            this.StartDate = now;

            this.EndDate = now.AddDays(manyDay);
        }
    }
}
