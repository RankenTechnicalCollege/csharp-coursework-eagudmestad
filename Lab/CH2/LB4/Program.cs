using System;

namespace LB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();//"Evan";


            // Console.WriteLine("{0}", firstName.Length);
            //Length property holds the number of characters in the string

            string firstInitial = firstName.Substring(0, 1);
            string restOfName = firstName.Substring(1, firstName.Length-1);
            Console.WriteLine("Hello {0}{1}ay", restOfName, firstInitial);
        }
    }
}
