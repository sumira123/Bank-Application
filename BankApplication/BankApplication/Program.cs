using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    static class Program
    {
         //start program
        [STAThread]
        static void Main()
        {
            //configuration setting for .net remoting
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new from_lgn());
            RemotingConfiguration.Configure(@"..\..\App.config", false);
        }
    }
}
