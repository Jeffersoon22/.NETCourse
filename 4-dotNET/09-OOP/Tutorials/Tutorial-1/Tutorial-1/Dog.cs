using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_1
{
    public class Dog : Animal, IEat
    {
        public override void AnimalCreated()
        {
            Console.WriteLine("Dog was created.");
        }

       /* public override void MakeVoice()
        {
            Console.WriteLine("Wuff!");
        }
*/
        public override void PawCount()
        {
            Console.WriteLine("I have 4 paws.");
        }

        public virtual void Consume()
        {
            Console.WriteLine("I'm fed") ;
        }

        public void ExpressHapiness()
        {
            Console.WriteLine("I am doggy happy!");
        }
    }
}
