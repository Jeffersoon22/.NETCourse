using System;
using System.Reflection;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Type myType = (typeof(CashMachine));

            MethodInfo[] myArrayMethodInfo = myType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            Console.WriteLine($"Count of public methods is {myArrayMethodInfo.Length}: ", myArrayMethodInfo.Length);
            for (int i = 0; i < myArrayMethodInfo.Length; i++)
            {
                Console.Write(myArrayMethodInfo[i].Name + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            MethodInfo[] myArrayMethodInfo1 = myType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            Console.WriteLine($"Count of nonpublic methods is {myArrayMethodInfo1.Length}: ", myArrayMethodInfo1.Length);
            for (int i = 0; i < myArrayMethodInfo1.Length; i++)
            {
                Console.Write(myArrayMethodInfo1[i].Name + ", ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
