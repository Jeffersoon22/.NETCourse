using System;

namespace Practice_3
{
    class Program 
    {
        static void Main(string[] args)
        {
            Racgindadaarqvi();
            GC.Collect();
        }

        static void Racgindadaarqvi()
        {
            Resource res = new Resource(1);
            Resource res2 = new Resource(2);
            res2.Dispose();
        }

    }
}
