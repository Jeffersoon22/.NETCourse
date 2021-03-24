using System;
using System.Text.RegularExpressions;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var ipaddres = new CheckValue();
            ipaddres.ValueChecker("192.0.2.235");
            Console.WriteLine();
            ipaddres.ValueChecker("0xC0.0x00.0x02.0xEB");
            Console.WriteLine();
            ipaddres.ValueChecker("0300.0000.0002.0353");
            Console.WriteLine();
            ipaddres.ValueChecker("0xC00002EB");
            Console.WriteLine();
            ipaddres.ValueChecker("3221226219");
            Console.WriteLine();
            ipaddres.ValueChecker("030000001353");
            Console.WriteLine();
            ipaddres.ValueChecker("1231edksajd1312");


        }


        public class CheckValue
        {


            public void ValueChecker(string ipadress)
            {
                Regex deccimal = new Regex(@"^((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){3}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})$");
                Regex hexadeccimal = new Regex(@"^(0x[0-9A-F]{2}\.){3}0x[0-9A-F]{2}$");
                Regex octal = new Regex(@"^(0?[0-3][0-7]{2}\.){3}0?[0-3][0-7]{2}$");
                Regex hexaDecimal = new Regex(@"^0x[0-9A-F]{8}$");
                Regex decimall = new Regex(@"^(429496729[0-5]|42949672[0-8][0-9]|4294967[0-1][0-9]{2}|429496[0-6][0-9]{3}|42949[0-5][0-9]{4}|4294[0-8]{5}|429[0-3][0-9]{6}|42[0-8][0-9]{7}|4[0-1][0-9]{8}|[0-3][0-9]{9}|[0-9]{1,9})$");
                Regex octall = new Regex(@"^0?[0-3][0-7]{10}$");

                if (deccimal.IsMatch(ipadress) || hexadeccimal.IsMatch(ipadress) || hexaDecimal.IsMatch(ipadress) || octal.IsMatch(ipadress) || octall.IsMatch(ipadress) || decimall.IsMatch(ipadress))
                {
                    Console.WriteLine(ipadress);
                    Console.WriteLine("All values are valid");
                }
                else
                {
                    Console.WriteLine(ipadress);
                    Console.WriteLine("Values are invalid");
                }

            }
        }
    }
}
