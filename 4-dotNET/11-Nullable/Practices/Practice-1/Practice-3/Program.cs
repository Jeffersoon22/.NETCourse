using System;

namespace Practice_3
{
    class Program
    {
        static private void validateuserName(out string firstname)
        {

            while (true)
            {
                Console.Write("Input your name: ");
                firstname = Console.ReadLine();

                if (string.IsNullOrEmpty(firstname))
                {
                    Console.WriteLine("Name is required! Let's try one more time!");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }


        static void Main(string[] args)
        {
            MyForm myForm = new MyForm();

            validateuserName(out string firstname);
            myForm.Name = firstname;


            Console.Write("Input your date of birth: ");

            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateTime))
            {
                myForm.DateOfBirth = dateTime;
            }
            string birthdatestring = myForm.DateOfBirth == null ? "" :
                myForm.DateOfBirth.Value.ToShortDateString();

            Console.WriteLine();

            Console.Write("How many childrens do you have?  ");

            if (int.TryParse(Console.ReadLine(), out int childrenCount))
            {
                myForm.CountOfChildrens = childrenCount;
            }

            Console.WriteLine();


            Console.Write("How many pets do you have? ");

            if (int.TryParse(Console.ReadLine(), out int petCount))
            {
                myForm.CountOfPets = petCount;
            }

            Console.WriteLine();

            Console.Write("Do you want to get proposal emails? (y / n)  ");
            string wantEmail = Console.ReadLine();

            if (wantEmail.ToLower() == "y")
            {
                myForm.AreProposalEmailsNeeded = true;
            }
            else if (wantEmail.ToLower() == "n")
            {
                myForm.AreProposalEmailsNeeded = false;
            }
            else
            {
                myForm.AreProposalEmailsNeeded = null;
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"|  {myForm.Name}  |  {birthdatestring}  |" +
                               $"  {myForm.CountOfPets}  |  {myForm.CountOfChildrens}  |" +
                               $"  {myForm.AreProposalEmailsNeeded}  |");

        }

        
    }
}
