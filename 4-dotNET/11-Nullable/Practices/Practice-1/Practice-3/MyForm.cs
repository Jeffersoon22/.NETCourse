using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class MyForm
    {
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? CountOfChildrens { get; set; }
        public int? CountOfPets { get; set; }
        public bool? AreProposalEmailsNeeded { get; set; }

        static public void MustBeNamed(out string firstname)
        {

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Input your name:");
                firstname = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(firstname))
                {
                    Console.WriteLine("Name is required! Let's try one more time");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
