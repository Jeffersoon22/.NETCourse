using System;

namespace Practice_4
{
    class Program
    {
        private const int MatrixLength = 5;
        private const int MatrixHeight = 5;
        static void Main(string[] args)
        {
            var matrix = new int[MatrixHeight, MatrixLength];
            int incrementIndex = 4;
            for (int height = 0; height < MatrixHeight; height++)
            {
                for (int lenght = 0; lenght < MatrixLength; lenght++)
                {
                    if (incrementIndex == lenght)
                    {
                        matrix[height, lenght]++;
                    }
                    Console.Write(matrix[height, lenght] + "\t");
                }
                incrementIndex--;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
