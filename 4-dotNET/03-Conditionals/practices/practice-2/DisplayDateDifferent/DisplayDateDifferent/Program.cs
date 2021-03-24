using System;

namespace DisplayDateDifferent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("======= Menu ====== \n" +
                "1.The current month \n" +
                "2.The current day of Week\n" +
                "3.The current year \n" +
                "0.Exit\n" +
                "===================\n" +
                "Select Menu number: ");


            string chosenNum = Console.ReadLine();
            bool isNumber = int.TryParse(chosenNum, out int number);

            if (!isNumber)
            {
                Console.WriteLine("Incorrect fotmat");
                Console.ReadKey();
                return;

            }
            else if (number == 0)
            {
                Console.WriteLine();
                Console.Write("Exiting now...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();

                string currentTime = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                Console.WriteLine($"The current date: {currentTime}");
                Console.WriteLine();

                switch (number)
                {
                    case (1):
                        string outMonth = DateTime.Now.ToString("MMMMMMMMMMM");
                        Console.WriteLine($"Month: {outMonth}");
                        break;
                    case (2):
                        string outDay = DateTime.Now.ToString("ddddddddd");
                        Console.WriteLine($"Day: {outDay}");
                        break;

                    case (3):
                        string outYear = DateTime.Now.ToString("yyyy");
                        Console.WriteLine($"Year: {outYear}");
                        break;
                    default:
                        Console.WriteLine("Untitled bind!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
