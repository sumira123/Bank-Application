using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace BankDbtier
{
    class Program
    {
        static void Main(string[] args)
        {
            //configuration of .net remoting server.
            Console.WriteLine("Server: Reading config file...");

            RemotingConfiguration.Configure(@"..\..\App.config", false);

            Console.WriteLine("Server is running");
            Console.WriteLine("Press Enter to stop.. ");

            Console.ReadLine();
            TcpChannel ch = new TcpChannel(8081);
            ChannelServices.RegisterChannel(ch,false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof
            (BankDbtier.DbBank), "bank", WellKnownObjectMode.Singleton);
            Console.Write("Sever is  Ready........");
            Console.Read();
        }
    }
}
