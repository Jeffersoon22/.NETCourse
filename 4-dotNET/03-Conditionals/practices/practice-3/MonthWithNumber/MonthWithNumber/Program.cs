using System;

namespace MonthWithNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of month: ");
            

            string stringMonth = Console.ReadLine();
            int number;
            bool isNum = int.TryParse(stringMonth,out number);

            if (!isNum)
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect format");
                Console.ReadKey();
            }


            /*-----Without Switch Case-----*/

            //Console.WriteLine();
            //DateTime now = DateTime.Now;
            //now = now.AddMonths(number);
            //string nowString = now.ToString("MMMMMMM");
            //Console.WriteLine($"Month: {nowString}");
            //Console.ReadKey();

            /*----------------------------*/

            switch ((Months)number)
            {
                case Months.January:
                    Console.WriteLine(Months.January.ToString());
                    break;
                case Months.February:
                    Console.WriteLine(Months.February.ToString());
                    break;
                case Months.March:
                    Console.WriteLine(Months.March.ToString());
                    break;
                case Months.April:
                    Console.WriteLine(Months.April.ToString());
                    break;
                case Months.May:
                    Console.WriteLine(Months.May.ToString());
                    break;
                case Months.June:
                    Console.WriteLine(Months.June.ToString());
                    break;
                case Months.July:
                    Console.WriteLine(Months.July.ToString());
                    break;
                case Months.August:
                    Console.WriteLine(Months.August.ToString());
                    break;
                case Months.September:
                    Console.WriteLine(Months.September.ToString());
                    break;
                case Months.October:
                    Console.WriteLine(Months.October.ToString());
                    break;
                case Months.November:
                    Console.WriteLine(Months.November.ToString());
                    break;
                case Months.December:
                    Console.WriteLine(Months.December.ToString());
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine($"Month {number} is not exists");
                    break;
            }
            Console.ReadKey();
           

        }
    }
}
