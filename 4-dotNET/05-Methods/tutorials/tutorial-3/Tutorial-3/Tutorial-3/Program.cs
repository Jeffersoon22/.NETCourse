using System;

namespace Tutorial_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInput(out double x, out double y,out double z);

            var result = Multiply(x, y, z);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int Multiply(int x, int y) => x * y;
        public static int Multiply(int x, int y, int z) => x * y * z;
        public static double Multiply(double x, double y) => x * y;
        public static double Multiply(double x, double y, double z) => x * y * z;

        public static void GetUserInput(out double x, out double y, out double z )
        {
            Console.WriteLine("Input array of numbers: ");
            string userInput = Console.ReadLine();

            var numbers = userInput.Split(" ");

            x = double.Parse(numbers[0]);
            y = double.Parse(numbers[1]);

            z = numbers.Length == 3
                ? z = double.Parse(numbers[2])
                : 1;
            
        }

        // static int Multiply(int x, int y)
        //{
        //    return x * y;
        //}

       // public static int Multiply(int x, int y , int z)
       // {
       //     return x * y * z;
       // }


        //public static double Multiply(double x, double y)
        //{
        //    return x * y;
        //}

        //public static double Multiply(double x, double y, double z)
        //{
        //    return x * y * z;
        //}
    }
}
