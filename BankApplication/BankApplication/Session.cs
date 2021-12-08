using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    //class works as a session
    public class Session
    {
        public User User { get; set; }
        public List<AccountClass> Accounts { get; set; }
        
        public Session()
        {
            Accounts = new List<AccountClass>();
            User = new User();
        }

    }
}
