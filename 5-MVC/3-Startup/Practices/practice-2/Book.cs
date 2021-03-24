using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice_2
{
    public class Book
    {


        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }



        public Book(string name, string author, int releaseYear)
        {
            Name = name;
            Author = author;
            ReleaseYear = releaseYear;
        }
    }
}
