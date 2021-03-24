using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>links = new List<string> { "docs.microsoft.com", "stackoverflow.com", "www.google.com" };

            Parallel.ForEach
            (links, link => 
                {
                    Ping ping = new Ping();
                    PingReply pingreply = ping.Send(link);
                    Console.WriteLine("{0}\t\tis  {1}", link, pingreply.Status);
                }
            );

        }
    }
}

