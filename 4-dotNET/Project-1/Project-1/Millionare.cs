using Management;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Project_1
{
    class Millionare
    {

        private const string FileName = @"..\..\..\..\Question.txt";
        private static int counter = 0;
        private static List<string> answers = new List<string> { };
        private static List<string> answerscopy = new List<string> { };
        private static Dictionary<string, int> answersIndex = new Dictionary<string, int> { { "A", 0 }, { "B", 1 }, { "C", 2 }, { "D", 3 } };
        private static List<string> shuffledList = new List<string>();

        private static DateTime startDateTime= new DateTime();
        private static int totalAmountOfQuestions = 0;
        private static int rightAnswers = 0;
        private static int wrongAnswers = 0;
        private static int takenMoney = 0;

        private static bool fiftyIsUsed = false;
        private static bool FriendIsUsed = false;
        private static bool AudienceIsUsed = false;

        public static string decryptedQuestionsXML ;
        public static XmlSerializer<List<Question>> xmlSerializer = new XmlSerializer<List<Question>>();
        public static List<Question> QuestionsData ;



        private static List<string> FiftyFifty(List<string> shufledList, string correctansw)
        {
            Console.WriteLine("\nTip accepted.\n");
            Random rand = new Random();
            
            int count = 0;
            while (count != 2)
            {
                int randindex = rand.Next(0, 4);
                if (shufledList[randindex] != correctansw && shufledList[randindex] != null)
                {
                    shufledList[randindex] = null;
                    count++;
                }
            }
            for(int i=0;i< shufledList.Count; i++)
            {
                if(shufledList[i] != null) 
                Console.WriteLine(answersIndex.ElementAt(i).Key + ": " + shufledList[i]);
            }
            return shufledList;

        }

        private static void PhoneFriend(List<string> shufledList)
        {
            Random friend = new Random();
            while (true)
            {
                int rand = friend.Next(0, 4);
                if (shuffledList[rand] != null)
                {
                    Console.WriteLine("Alex, your friend: I don't know maybe... {0}", answersIndex.FirstOrDefault(x => x.Value == rand).Key);
                    break;
                }
            }
        }

        private static void Audience(List<string> shuffledList,string correctansw)
        {
            Random audience = new Random();
            int rand = audience.Next(0, 100);
            string result = "";
            if(rand < 85)
            {
                result = answersIndex.FirstOrDefault(x => x.Value == shuffledList.IndexOf(correctansw)).Key;

            }
            else
            {
                while (true)
                {
                    int newansw = audience.Next(0, 4);
                    if (shuffledList[newansw]!=correctansw  && shuffledList[newansw] != null)
                    {
                        result = answersIndex.FirstOrDefault(x => x.Value == newansw).Key;
                        break;
                    }
                }
            }

            Console.WriteLine($"Audience: correct answer is {result}");

        }

        static void Main(string[] args)
        {
            string readquestions="";
            var aesOperation = new Decryptor();
            try
            {
                readquestions = File.ReadAllText(FileName);
            }
            catch
            {
                Console.WriteLine("File for questions does not exist!");
                Console.WriteLine("Please run first Management console application");
            }
            try
            {
                decryptedQuestionsXML = aesOperation.DecryptString(readquestions);
                xmlSerializer = new Management.XmlSerializer<List<Management.Question>>();
                QuestionsData = xmlSerializer.Deserialize(decryptedQuestionsXML);
            
                Console.WriteLine("Welcome to game `Who Wants to be a Millionaire?`");
                Console.WriteLine();
                Console.Write("Are you ready yo start? (y/n): ");
                string startOrnot = Console.ReadLine().ToLower();
                Console.Clear();


                if (startOrnot == "n" || startOrnot == "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("Are you not ready?\n\nI was not ready for this Project too...");
                    Console.ReadKey();

                }
                else if (startOrnot == "y" || startOrnot == "yes")
                {
                    startDateTime = DateTime.Now;
                    bool continuegame = true;

                    while (counter < QuestionsData.Count && continuegame)
                    {
                        totalAmountOfQuestions++;
                        Console.Clear();
                        answers = new List<string>();
                        answers.Add(QuestionsData[counter].Correct);
                        answers.Add(QuestionsData[counter].Wrong1);
                        answers.Add(QuestionsData[counter].Wrong2);
                        answers.Add(QuestionsData[counter].Wrong3);
                        shuffledList = new List<string>();
                        foreach (string answ in answers)
                        {
                            answerscopy.Add(answ);

                        }


                        Console.WriteLine("Question {0} for ${1}: ", counter + 1, QuestionsData[counter].Cost);
                        Console.WriteLine(QuestionsData[counter].Que);
                        Console.WriteLine();



                        int i = 0;
                        while (answerscopy.Count != 0)
                        {
                            Random rand = new Random();
                            var randomnumber = rand.Next(0, answerscopy.Count);
                            Console.WriteLine(answersIndex.ElementAt(i).Key + ": " + answerscopy[randomnumber]);
                            shuffledList.Add(answerscopy[randomnumber]);
                            answerscopy.RemoveAt(randomnumber);
                            ++i;

                        }
                        Console.WriteLine("\n--------------------------Other options--------------------------");
                        if (counter > 2)
                        {
                            Console.WriteLine("0:\tTake money\n");
                        }
                        Console.WriteLine("Avaliable tips:");
                        if (!fiftyIsUsed) { Console.WriteLine("1:\t50:50"); }
                        if (!FriendIsUsed) { Console.WriteLine("2:\tPhone-A-friend"); }
                        if (!AudienceIsUsed) { Console.WriteLine("3:\tAsk the audience"); }


                        while (true)
                        {
                            Console.Write("\nYour choice: ");
                            string inputedanswer = Console.ReadLine().ToUpper();
                            bool inputedAnswerIsInt = int.TryParse(inputedanswer, out int inputedInt);
                            try
                            {
                                if (inputedanswer.Length == 0)
                                {
                                    Console.WriteLine("\nAnswer should not be empty...");


                                }
                                else if (inputedAnswerIsInt)
                                {
                                    try
                                    {
                                        if (inputedInt == 0 && counter > 2)
                                        {
                                            continuegame = false;
                                            Console.WriteLine("You win ${0}", QuestionsData[counter - 1].Cost);
                                            takenMoney = QuestionsData[counter - 1].Cost;
                                            break;
                                        }
                                        else if (inputedInt == 1 && !fiftyIsUsed)
                                        {

                                            shuffledList = FiftyFifty(shuffledList, answers[0]);
                                            fiftyIsUsed = true;
                                        }
                                        else if (inputedInt == 2 && !FriendIsUsed)
                                        {
                                            PhoneFriend(shuffledList);
                                            FriendIsUsed = true;
                                        }
                                        else if (inputedInt == 3 && !AudienceIsUsed)
                                        {
                                            Audience(shuffledList, answers[0]);
                                            AudienceIsUsed = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Incorrect Input...");
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Incorrect operation...");
                                    }
                                }
                                else if (shuffledList[answersIndex[inputedanswer]] == answers[0])
                                {
                                    rightAnswers++;
                                    Console.WriteLine("You are gorgeous!");
                                    Thread.Sleep(2000);
                                    counter++;
                                    if (counter == QuestionsData.Count)
                                    {
                                        Console.WriteLine("You win ${0}", QuestionsData[counter - 1].Cost);
                                        takenMoney = QuestionsData[counter - 1].Cost;
                                    }

                                    break;
                                }
                                else if (shuffledList[answersIndex[inputedanswer]] == null)
                                {
                                    Console.WriteLine("50:50 removes this answer...");
                                }
                                else
                                {
                                    wrongAnswers++;
                                    Console.WriteLine("Unfortunately, this is the wrong answer... Game over.");
                                    continuegame = false;
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.Write("Incorrect input ");
                            }
                        }
                    }

                    try
                    {
                        string GameHistory = @"..\..\..\..\GameHistory.txt";
                        if (!File.Exists(GameHistory))
                        {
                            var createHistory = File.Create(GameHistory);
                            createHistory.Close();
                        }


                        File.AppendAllText(GameHistory,
                            $"Start of game: {startDateTime}\n" +
                            $"Total amount of questions:{totalAmountOfQuestions}\n" +
                            $"Right answers: {rightAnswers}\n" +
                            $"Wrong answers: {wrongAnswers}\n" +
                            $"Money won: {takenMoney}\n\n");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("File cannot load...");
                    }
                }
                else
                {
                    Console.WriteLine("I don't know what to do now...");
                    Console.ReadKey();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
