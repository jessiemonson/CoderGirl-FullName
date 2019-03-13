using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.

            Console.Write("Please enter your first name.:");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name.:");
            string lastName = Console.ReadLine();
            Console.WriteLine(FullName(firstName, lastName));

            Console.ReadLine();
        }

        public static string FullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
            
        }

        
    }
}
