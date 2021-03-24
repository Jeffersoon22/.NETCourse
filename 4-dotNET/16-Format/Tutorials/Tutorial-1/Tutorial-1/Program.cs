using System;
using System.Globalization;
namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var condition = true;

            do
            {
                Console.WriteLine(Resources.Resources.Greeting);
                Console.WriteLine(Resources.Resources.Language);
                Console.WriteLine(Resources.Resources.English);
                Console.WriteLine(Resources.Resources.Russian);
                Console.Write(Resources.Resources.Choice);

                var choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
                        break;
                    case "2":
                        CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("ru-RU");
                        break;
                    default:
                        Console.WriteLine("Bye");
                        condition = false;
                        break;
                }
            } while (condition);
        }
    }
}
