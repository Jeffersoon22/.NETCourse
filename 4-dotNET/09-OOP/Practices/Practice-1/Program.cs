using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCAr = new Car(180);
            Jeep myJeep = new Jeep(250);

            myCAr.GetCurrentSpeed(200);
            myJeep.GetCurrentSpeed(250);
            Console.ReadKey();
            
        }
    }
}
