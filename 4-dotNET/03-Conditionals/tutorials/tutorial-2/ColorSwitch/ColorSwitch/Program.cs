using System;

namespace ColorSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rainbow color number: ");
            string colorString = Console.ReadLine();

            int color;
            var isNumber = int.TryParse(colorString, out color);

            Console.WriteLine();

            if (!isNumber)
            {
                Console.WriteLine("Incorrect fotmat");
                Console.ReadKey();
                return;
            }


            switch ((Colors)color)
            {
                case Colors.Red:
                    Console.WriteLine(Colors.Red.ToString());
                    break;

                case Colors.Orange:
                    Console.WriteLine(Colors.Orange.ToString());
                    break;

                case Colors.Yellow:
                    Console.WriteLine(Colors.Yellow.ToString());
                    break;

                case Colors.Green:
                    Console.WriteLine(Colors.Green.ToString());
                    break;

                case Colors.Blue:
                    Console.WriteLine(Colors.Blue.ToString());
                    break;
                case Colors.Indigo:
                    Console.WriteLine(Colors.Indigo.ToString());
                    break;

                case Colors.Violet:
                    Console.WriteLine(Colors.Violet.ToString());
                    break;

                default:
                    Console.WriteLine("white");
                    break;
            }

            Console.ReadKey();
        }

    }
}
