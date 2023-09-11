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
        public string UserSurname { get; private set; }
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }
        public string DocumentID { get; private set; }



        /// <param name="userName"> Indicate only the user name </param>
        /// <param name="days"> Indicate the duration expressed in days </param>
        public Borrowed(User user,int days, string itemID )
        {
            this.UserName = user.Name;
            this.UserSurname = user.Surname;    

            DateTime now = DateTime.Now;
            this.StartDate = now.ToString("d");

            this.EndDate = now.AddDays(days).ToString("d");
        }
    }
}
