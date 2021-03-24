using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            string[] history = new string[10];
            string answer = "y";
            while (answer == "y")
            {
                Console.Write("Input number x: ");
                string stringX = Console.ReadLine();
                float numX;
                bool isIntX = float.TryParse(stringX, out numX);



                if (!isIntX)
                {
                    Console.WriteLine($"Inaccessible operation: {stringX} is not a number");
                    history[index] = $"Inaccessible operation: {stringX} is not a number";
                    index++;
                    if (history.Length != 0)
                    {
                        break;
                    }
                }
                Console.Write("Input number y: ");
                string stringY = Console.ReadLine();
                float numY;
                bool isIntY = float.TryParse(stringY, out numY);

                if (!isIntY)
                {
                    Console.WriteLine($"Inaccessible operation: {stringY} is not a number");
                    history[index] = $"Inaccessible operation: {stringY} is not a number";
                    index++;
                    if (history.Length != 0)
                    {
                        break;
                    }
                }
                
                Console.WriteLine();

                Console.WriteLine("Choose a mathematical operation from the following list:");
                Console.WriteLine("1 - Add \n" + "2 - Subtract \n" + "3 - Multiply \n" + "4 - Divide");
                Console.Write("Option: ");

                string stringOperation = Console.ReadLine();
                float operation;
                bool isOperationNum = float.TryParse(stringOperation, out operation);

                if (isOperationNum)
                {
                    switch ((Operations)operation)
                    {
                        case Operations.Add:
                            Console.WriteLine($"Result: {numX} + {numY} = {numX + numY}");
                            history[index] = $"{numX} + {numY} = {numX + numY}";
                            index++;
                            break;
                        case Operations.Subtract:
                            Console.WriteLine($"Result: {numX} - {numY} = {numX - numY}");
                            history[index] = $"{numX} - {numY} = {numX - numY}";
                            index++;
                            break;
                        case Operations.Multiply:
                            Console.WriteLine($"Result: {numX} * {numY} = {numX * numY}");
                            
                            history[index] = $"{numX} * {numY} = {numX * numY}";
                            index++;
                            break;
                        case Operations.Divide:
                            if (numX == 0 || numY == 0)
                            {
                                Console.WriteLine("Inaccessible operation: You cannot divide by zero.");
                                history[index] = "Inaccessible operation: You cannot divide by zero.";
                                index++;
                            }
                            else
                            {
                                float division = numX / numY;
                                Console.WriteLine($"Result: {numX} : {numY} = {division}");
                                history[index] = $"{numX} : {numY} = {division}";
                                index++;
                            }
                            break;
                        default:
                            Console.WriteLine("Untitled operation");
                            history[index] = "Untitled operation";
                            index++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Inaccessible operation: '{stringOperation}' is not a number");
                    history[index] = $"Inaccessible operation: '{stringOperation}' is not a number";
                    index++;
                }
                Console.WriteLine();
                Console.Write("Continue (y/n): ");
                string answerString = Console.ReadLine();
                answer = answerString;
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------History-------");
            Console.WriteLine();
            int indexOfHisory = 0;
            foreach(string hist in history)
            {
                indexOfHisory++;
                bool histIslong = hist != null;
                while (histIslong)
                {
                    Console.WriteLine(indexOfHisory + ") " + hist);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
