using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    class Resource
    {
        public int Id { get; set; }

        public Resource(int id)
        {
            this.Id = id;
        }

        ~Resource()
        {
            Console.WriteLine($"Resource {Id} was created ");
        }
    }
}
