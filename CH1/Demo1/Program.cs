using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //a variable with an identifier of sumOfMoney
            //this is a naming convention called camel casing
            //sum holds a value of 12
            //the data type is an int
            int sumOfMoney  = 12;

            int SumOfMoney = 123; //Pascal Casing

            //data types
            //tell us what kind of data our variables store
            //int is a whole number (no decmial points)
            //byte, short, int, long all store whole  numbers
            //The range of values they can store is how they differ

            byte personsAge = 120; //byte data types can store numbers
            //between 0 and 255

            short distanceTraveled = 30000; //short data types can store
            //numbers between ~-32,200 through +32,199

            int sumOfNumbers = 1291432434;

            long bigNumberHere = 45654654654654654;

            //languages with data types are considered strict
            //languages without data types are considered loose
            //JS is considered a loosely typed language
            //TypeScript - is strict JS
            //C# is strict

            //float and double data types can store decimal places
            //a float can store 7 digits of precision
            float aDecimalNumber = 1234.121234f;

            //a double can store 15 digits of precsion
            double anotherNumber = 1234.2123412344;

            //Declaring a variable is when you give it a data type
            //This is when the space in RAM is reserved
            int yourAge;

            //Assigning a variable means giving it a value
            yourAge = 12;
            //output yourAge here ----- 12

            yourAge = 13;
            //output yourAge here ------ 13

            //bool data types hold true or false
            bool isMonday = true;
            bool isTuesday = false;

            char middleInitial = 'A';
            char exitKey = '!';

           // Console.WriteLine(exitKey);

            int age = 12;

            age = 13;

            const double TAX_RATE = .33;

            //Lets get some user input
            //Needed for labs
            //Ask the user their name and age
            
            //Prompt the user for their information
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            float userAge = float.Parse(Console.ReadLine());

            Console.WriteLine("How many dollars do you have?");
            int dollars = int.Parse(Console.ReadLine());

            //Math
            int casinoWinner = dollars * 100;
            
            
            
            //output that information
            Console.WriteLine("{0} is {1} years old and won at the casino {2:C} .", firstName, userAge, casinoWinner);

            //Dairy Queen
            //Car would input their order to me
            //my register would do some math
            //I would output the total to the customer

            //Input
            //Math
            //Output

        }
    }
}
