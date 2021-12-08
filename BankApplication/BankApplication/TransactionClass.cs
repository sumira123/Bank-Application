using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class TransactionClass
    {
        public uint TransactionId { get; set; }
        public uint Amount { get; set; }
        public uint senderacc { get; set; }
        public uint recieveracc { get; set; }
    }
}
