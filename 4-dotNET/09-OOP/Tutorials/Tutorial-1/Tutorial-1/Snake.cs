using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    public class Snake : Animal
    {
       public Snake()
        {
            Console.WriteLine("A new snake was born!");
        }
        public override void AnimalCreated()
        {
            Console.WriteLine("Snake was created.");
        }

        public override void MakeVoice()
        {
            Console.WriteLine("Tssss!");
        }

        public override void PawCount()
        {
            base.PawCount();
            Console.WriteLine("I'm a snake, I'm cool without paws.");
        }
    }
}
