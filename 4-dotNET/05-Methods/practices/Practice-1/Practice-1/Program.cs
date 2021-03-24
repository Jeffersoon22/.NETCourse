using System;

namespace Practice_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Underweight = <18.5\n" +
                "Normal weight = 18.5–24.9 \n" +
                "Overweight = 25–29.9\n" +
                "Obesity = BMI of 30 or greater");
            Console.WriteLine();

            Console.Write("Input your name: ");
            string name = Console.ReadLine();

            Console.Write("Input weight(kg): ");
            string stringWeight = Console.ReadLine();
            float weight;
            weight = float.Parse(stringWeight);

            Console.Write("Input height(m): ");
            string stringHeight = Console.ReadLine();
            float height;
            height = float.Parse(stringHeight);
            Console.WriteLine();
            Console.WriteLine();
            float result = GetBMI(weight, height);
            Console.WriteLine($"{name} Your BMI =  " + Math.Round(result,2));
          

            if (result < 18.5)
            {
                Console.WriteLine("BMI category : Underweight");
            }
            else if (18.5 < result && result < 24.9)
            {
                Console.WriteLine("BMI category : Normal weight");
            }
            else if (25 < result && result < 29.9)
            {
                Console.WriteLine("BMI category : Overweight");
            }
            else
            {
                Console.WriteLine("BMI category : Obesity");
            }
            Console.ReadKey();
        }

        public static float GetBMI(float a ,float b)
        {
            float bmi = a / (b * b);
            return bmi;
        }
    }
}
