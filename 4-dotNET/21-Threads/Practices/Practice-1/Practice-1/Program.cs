using System;
using System.Threading;
namespace Practice_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("How many threads do you want? (1 or 2)  ");
			string numOfThreads = Console.ReadLine();
			
			Thread thread = new Thread(PrintNumbers);
			thread.Start();

			Console.WriteLine("-> Primary is executing Main() ");
			if (numOfThreads == "1")
			{
				thread.Join();
			}

			Console.WriteLine("Main method last thing ");
		}
		static void PrintNumbers()
		{
			Console.WriteLine("-> Secondary is executing PrintNumbers()");
			Console.Write("Your numbers: ");


			for (int i = 0; i < 10; i++)
			{
				Console.Write("{0}, ",i);
				Thread.Sleep(1000);
			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}