using System;
using System.Text;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "It is â t€st";

            byte[] bytes = Encoding.ASCII.GetBytes(text);

            string bytestring = "";

            foreach(byte i in bytes)
            {
                string stringbyte = i.ToString();
                bytestring += $" {i}";

            }

            Console.WriteLine("Byte codes: " + bytestring);
            Console.WriteLine("ASCII: \t\t" + Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(text)));
            Console.WriteLine("UTF8: \t\t" + Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text)));



        }
    }
}
