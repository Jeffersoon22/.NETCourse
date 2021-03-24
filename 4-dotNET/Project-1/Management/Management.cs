using System;
using System.Collections.Generic;
using System.IO;

namespace Management
{
    public static class Management
    {
        private const string FileName = @"..\..\..\..\Question.txt";
        private static int count = 0;
        private static List<int> costs = new List<int> { 700, 12000, 70000, 120000, 700000, 1000000 };
        private static List<Question> QuestionsData = new List<Question> { };

        public static string GetInputQuestion(int counter)
        {
            int questionprice = costs[counter];
            string inputQueston = "Enter question for $" + questionprice + ":";
            return inputQueston;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hello. Let's start entering questions? (y/n): ");

                string enterQueorNot = Console.ReadLine().ToLower();
                if (enterQueorNot == "n" || enterQueorNot == "no")
                {
                    Console.WriteLine("Okay, bye!");
                }
                else if (enterQueorNot == "y" || enterQueorNot == "yes")
                {
                    try
                    {
                        while (count < 6)
                        {
                            Console.WriteLine();
                            Console.WriteLine(GetInputQuestion(count));
                            string question = Console.ReadLine();
                            bool questionIsvalid = question.Length > 1;

                            if (!questionIsvalid)
                            {
                                while (!questionIsvalid)
                                {
                                    Console.Write($"\nQuiestion is not valid\n{GetInputQuestion(count)}");
                                    question = Console.ReadLine();
                                    if (question.Length > 1)
                                    {
                                        break;
                                    }
                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine("\nEnter correct answer: ");
                            string correctAnswer = Console.ReadLine();
                            Console.WriteLine("");
                            bool correctAnswerIsvalid = correctAnswer.Length > 0;


                            if (!correctAnswerIsvalid)
                            {
                                while (!correctAnswerIsvalid)
                                {
                                    Console.Write("Answer should not be empty...\nEnter correct answer again: ");
                                    correctAnswer = Console.ReadLine();
                                    Console.WriteLine();
                                    if (correctAnswer.Length > 0)
                                    {
                                        break;
                                    }
                                }
                            }

                            Console.WriteLine("\nEnter first wrong answer: ");
                            string wrong1 = Console.ReadLine();
                            if (wrong1 == correctAnswer)
                            {
                                while (wrong1 == correctAnswer)
                                {
                                    Console.WriteLine("This answer is already in answers list");
                                    Console.Write("Enter first wrong answer again: ");
                                    wrong1 = Console.ReadLine();
                                    if (wrong1 != correctAnswer)
                                    {
                                        break;
                                    }
                                }

                            }

                            Console.WriteLine("\nEnter second wrong answer: ");
                            string wrong2 = Console.ReadLine();
                            if (wrong2 == correctAnswer || wrong2 ==wrong1)
                            {
                                while (wrong2 == correctAnswer || wrong2 == wrong1)
                                {

                                    Console.WriteLine("This answer is already in answers list");
                                    Console.Write("Enter second wrong answer again: ");
                                    wrong2 = Console.ReadLine();
                                    if (wrong2 != correctAnswer && wrong2 !=wrong1)
                                    {
                                        break;
                                    }
                                }
                            }


                            Console.WriteLine("\nEnter third wrong answer: ");
                            string wrong3 = Console.ReadLine();

                            if (wrong3 == correctAnswer || wrong2 == wrong2 || wrong3 == wrong1)
                            {
                                while (wrong3 == correctAnswer || wrong3 == wrong2 || wrong3 == wrong1)
                                {
                                    Console.WriteLine("This answer is already in answers list");
                                    Console.Write("Enter third wrong answer again: ");
                                    wrong3 = Console.ReadLine();
                                    if (wrong3 != correctAnswer && wrong3 != wrong2 && wrong3 != wrong1)
                                    {
                                        break;
                                    }
                                }

                            }

                            var Question = new Question(question, correctAnswer, wrong1, wrong2, wrong3, costs[count]);
                            QuestionsData.Add(Question);
                            count++;

                            

                        }
                        try
                        {
                            var xmlSerializer = new XmlSerializer<List<Question>>();

                            var serializedQuestions = xmlSerializer.Serialize(QuestionsData);
                            var aesOperation = new Encryptor();

                            var encryptedSerializedQue = aesOperation.EncryptString(serializedQuestions);


                            File.WriteAllText(FileName, encryptedSerializedQue);

                            Console.WriteLine("Thank you! Data was stored and encrypted.");
                            Console.ReadKey();
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Information can not be saved or encrypted...");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("I don't know what to do now...");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
