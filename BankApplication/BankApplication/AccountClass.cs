using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class AccountClass
    {
        public uint accid { get; set; }
        public uint balance { get; set; }
        public List<TransactionClass> transactions { get; set; }

        public AccountClass()
        {
            transactions = new List<TransactionClass>();
        }

    }
}
