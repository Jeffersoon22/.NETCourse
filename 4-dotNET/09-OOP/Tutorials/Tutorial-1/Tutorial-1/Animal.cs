using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    public abstract class Animal
    {
        public Animal()
        {
            AnimalCreated();
        }

        public abstract void AnimalCreated();
        public virtual void MakeVoice()
        {
            Console.WriteLine("I dont know which animal i am");
        }
        public virtual void PawCount()
        {
            Console.WriteLine("I have no paws.");
        }
        public void ExpressHapiness()
        {
            Console.WriteLine("I am basically ok!");
        }
    }
}
