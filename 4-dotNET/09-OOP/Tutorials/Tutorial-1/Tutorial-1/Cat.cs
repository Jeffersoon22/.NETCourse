using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    public class Cat : Animal
    {
        public override void AnimalCreated()
        {
            Console.WriteLine("Cat was created.");
        }

        public override void MakeVoice()
        {
            Console.WriteLine("Meow!");
        }

        public override void PawCount()
        {
            Console.WriteLine("I have 4 paws.");
        }
    }
}
