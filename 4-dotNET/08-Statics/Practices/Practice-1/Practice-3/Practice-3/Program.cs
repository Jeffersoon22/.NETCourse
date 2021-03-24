using System;
using System.Collections.Generic;

namespace Practiece_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<char, String> morse = new Dictionary<char, String>()
            {
                {'A' , ".-"},{'B' , "-..."},{'C' , "-.-."},
                {'D' , "-.."},{'E' , "."},{'F' , "..-."},
                {'G' , "--."},{'H' , "...."},{'I' , ".."},
                {'J' , ".---"},{'K' , "-.-"},{'L' , ".-.."},
                {'M' , "--"},{'N' , "-."},{'O' , "---"},
                {'P' , ".--."},{'Q' , "--.-"},{'R' , ".-."},
                {'S' , "..."},{'T' , "-"},{'U' , "..-"},
                {'V' , "...-"},{'W' , ".--"},{'X' , "-..-"},
                {'Y' , "-.--"},{'Z' , "--.."},{'0' , "-----"},
                {'1' , ".----"},{'2' , "..---"},{'3' , "...--"},
                {'4' , "....-"},{'5' , "....."},{'6' , "-...."},
                {'7' , "--..."},{'8' , "---.."},{'9' , "----."}, { ' ' , " "}};

            string mustChange = "";
            string newText = "";
            Console.Write("Enter text you want to change to Morse code: ");
            mustChange = Console.ReadLine();
            mustChange = mustChange.ToUpper();


            foreach (char i in mustChange)
            {
                if (morse.ContainsKey(i))
                {
                    newText += morse[i];
                    newText += " ";
                }
            }
            Console.WriteLine("Text in Morse Code: ");
            Console.WriteLine();
            Console.WriteLine(newText);
            Console.ReadKey();
        }
    }
}