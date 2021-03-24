using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var cat = new Cat();
           *//* cat.MakeVoice();
            cat.PawCount();*//*

            var baseCat = (Animal)cat;
            baseCat.MakeVoice();
*/

            Console.WriteLine();
            Console.WriteLine();

            /*var snake = new Snake();
            snake.MakeVoice();
            snake.PawCount();
            var dog = new Dog();
            dog.MakeVoice();*/

            /*var dog = new Dog();
            dog.MakeVoice();
            dog.Consume();
            dog.PawCount();
            dog.ExpressHapiness();*/

            var cobra = new Cobra();
            cobra.PawCount();
        }
    }
}
