using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02_Exercise_String2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string here: ");
            //Read first input string.
            string input = Console.ReadLine();

            Console.Write("Enter a Character to search : ");
            //Read the character inputto search
            char searchInput = Console.ReadLine()[0];

            //Gets the Index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            //Prints the Index as a search result on console.
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            Console.Write("Enter first name : ");
            //Read first Name
            string firstName = Console.ReadLine();
            Console.Write("Enter last name : ");
            //Read last Name
            string lastName = Console.ReadLine();
            
            //Concatinate the firstName and lastName variable and assign that to fullName variable.
            string fullName = string.Concat(firstName, " ",  lastName);
            //Prints the full name on the console
            Console.WriteLine("Your full name is {0}", fullName);

            Console.ReadKey();
        }
    }
}
