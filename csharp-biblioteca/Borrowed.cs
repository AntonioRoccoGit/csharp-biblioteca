using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Borrowed
    {
        public string UserName { get; private set; }
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }

       
        /// <param name="userName"> Indicate only the user name </param>
        /// <param name="days"> Indicate the duration expressed in days </param>
        public Borrowed(string userName, int days)
        {
            this.UserName = userName;

            DateTime now = DateTime.Now;
            this.StartDate = now.ToString("d");

            this.EndDate = now.AddDays(days).ToString("d");
        }
    }
}
