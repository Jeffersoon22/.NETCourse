using System;

namespace Practice__2
{
    class Program
    {
        private static string Tab = "\t";
        static void Main(string[] args)
        {
            Console.WriteLine(Tab + Tab + "Menu");
            Console.WriteLine();
            Console.WriteLine("1. Use current date \n2.Enter the date");
            Console.WriteLine();
            Console.Write("Select your choose: ");
            string chosenOptipon = Console.ReadLine();
            Console.WriteLine();
            if (chosenOptipon == "1")
            {
                Console.WriteLine();
                Console.Write("Avilable formats:\n" + Tab + "1. Short date pattern\n\t" +
                    "2. Long date pattern\n\t3. Full date / time pattern(short time)\n\t" +
                    "4. Full date/time pattern (long time)\n\t" +
                    "5. General date/time pattern (short time)\n\t" +
                    "6. General date/time pattern (long time)\n\t" +
                    "7. Month/day pattern\n\t" +
                    "8. Round-trip date/time pattern\n\t" +
                    "9. RFC1123 pattern\n\t" +
                    "10. Sortable date/time pattern\n\t" +
                    "11. Short time pattern\n\t" +
                    "12. Long time pattern\n\t" +
                    "13. Universal sortable date/time pattern\n\t" +
                    "14. Universal full date/time pattern\n\t" +
                    "15. Year month pattern.\n\t" +
                    "\n\t...\nSelect your choose: ");
                string selectFormat = Console.ReadLine();
                Console.WriteLine();

                if (selectFormat == "1")
                {
                    Console.WriteLine(DateTime.Now.ToString("d"));
                }
                else if (selectFormat == "2")
                {
                    Console.WriteLine(DateTime.Now.ToString("D"));
                }
                else if (selectFormat == "3")
                {
                    Console.WriteLine(DateTime.Now.ToString("f"));
                }
                else if (selectFormat == "4")
                {
                    Console.WriteLine(DateTime.Now.ToString("F"));
                }
                else if (selectFormat == "5")
                {
                    Console.WriteLine(DateTime.Now.ToString("g"));
                }
                else if (selectFormat == "6")
                {
                    Console.WriteLine(DateTime.Now.ToString("G"));
                }
                else if (selectFormat == "7")
                {
                    Console.WriteLine(DateTime.Now.ToString("M"));
                }
                else if (selectFormat == "8")
                {
                    Console.WriteLine(DateTime.Now.ToString("O"));
                }
                else if (selectFormat == "9")
                {
                    Console.WriteLine(DateTime.Now.ToString("R"));
                }
                else if (selectFormat == "10")
                {
                    Console.WriteLine(DateTime.Now.ToString("s"));
                }
                else if (selectFormat == "11")
                {
                    Console.WriteLine(DateTime.Now.ToString("S"));
                }
                else if (selectFormat == "12")
                {
                    Console.WriteLine(DateTime.Now.ToString("T"));
                }
                else if (selectFormat == "13")
                {
                    Console.WriteLine(DateTime.Now.ToString("u"));
                }
                else if (selectFormat == "14")
                {
                    Console.WriteLine(DateTime.Now.ToString("U"));
                }
                else if (selectFormat == "15")
                {
                    Console.WriteLine(DateTime.Now.ToString("Y"));
                }
            }
            else if (chosenOptipon == "2")
            {
                Console.Write("Enter the year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Enter the month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Enter the day: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Enter the hour: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Enter the minutes: ");
                int minute= int.Parse(Console.ReadLine());
                Console.Write("Enter the seconds: ");
                int second= int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Your date is ... ");
                Console.WriteLine();
                Console.WriteLine();
                
                Console.Write("Avilable formats:\n" + Tab + "1. Short date pattern\n\t" +
                    "2. Long date pattern\n\t3. Full date / time pattern(short time)\n\t" +
                    "4. Full date/time pattern (long time)\n\t" +
                    "5. General date/time pattern (short time)\n\t" +
                    "6. General date/time pattern (long time)\n\t" +
                    "7. Month/day pattern\n\t" +
                    "8. Round-trip date/time pattern\n\t" +
                    "9. RFC1123 pattern\n\t" +
                    "10. Sortable date/time pattern\n\t" +
                    "11. Short time pattern\n\t" +
                    "12. Long time pattern\n\t" +
                    "13. Universal sortable date/time pattern\n\t" +
                    "14. Universal full date/time pattern\n\t" +
                    "15. Year month pattern.\n\t" +
                    "\n\t...\nSelect your choose: ");
                string selectFormat = Console.ReadLine();
                Console.WriteLine();

                DateTime inputedTime = new DateTime(year, month,day,hour,minute,second);
                
                if (selectFormat == "1")
                {
                    Console.WriteLine(inputedTime.ToString("d"));
                }
                else if (selectFormat == "2")
                {
                    Console.WriteLine(inputedTime.ToString("D"));
                }
                else if (selectFormat == "3")
                {
                    Console.WriteLine(inputedTime.ToString("f"));
                }
                else if (selectFormat == "4")
                {
                    Console.WriteLine(inputedTime.ToString("F"));
                }
                else if (selectFormat == "5")
                {
                    Console.WriteLine(inputedTime.ToString("g"));
                }
                else if (selectFormat == "6")
                {
                    Console.WriteLine(inputedTime.ToString("G"));
                }
                else if (selectFormat == "7")
                {
                    Console.WriteLine(inputedTime.ToString("M"));
                }
                else if (selectFormat == "8")
                {
                    Console.WriteLine(inputedTime.ToString("O"));
                }
                else if (selectFormat == "9")
                {
                    Console.WriteLine(inputedTime.ToString("R"));
                }
                else if (selectFormat == "10")
                {
                    Console.WriteLine(inputedTime.ToString("s"));
                }
                else if (selectFormat == "11")
                {
                    Console.WriteLine(inputedTime.ToString("S"));
                }
                else if (selectFormat == "12")
                {
                    Console.WriteLine(inputedTime.ToString("T"));
                }
                else if (selectFormat == "13")
                {
                    Console.WriteLine(inputedTime.ToString("u"));
                }
                else if (selectFormat == "14")
                {
                    Console.WriteLine(inputedTime.ToString("U"));
                }
                else if (selectFormat == "15")
                {
                    Console.WriteLine(inputedTime.ToString("Y"));
                }

            }
        }
    }
}
