using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    class Resource : IDisposable
    {
        public int Id { get; set; }

        public Resource(int id)
        {
            this.Id = id;
            Console.WriteLine($"Resource {Id} was created ");
        }

        ~Resource()
        {
            Console.WriteLine($"Resource {Id} destroyed ");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Dispose managed resources");
        }
    }
}
