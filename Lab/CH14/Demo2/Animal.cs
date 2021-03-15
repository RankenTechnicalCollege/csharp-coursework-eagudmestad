using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public abstract class Animal : Object
    {
        //the abstract keyword means that you can not 
        //create an instance of this class

        //Instance Fields

        //Methods
        //Constructors can be used to SET your fields/properties
        public Animal(string name,int age,int numLegs)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numLegs;
        }

        public Animal()
        {

        }
        //Auto Implemented Properties
        //Automatically implement the fields
        //When you use an auto implmented property....
        //YOU DO NOT have to code the instance fields
        //aka its a coding shortcut
        //and it's really short
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        //ToString() method can be used to GET whatever data
        //from an object that you want
        public override String ToString()
        {
            return String.Format($"{Name} is {Age} years old and has {NumberOfLegs} legs");
        }

        //GetHashCode() is a method that should return a 
        //unique identifier for your object
        //typically it's an ID 
        //such as student ID
        public override bool Equals(object obj)
        {
            //Parents can be DOWNcasted into their children
            Animal a1 = (Animal)obj;
            bool equality = false;
            if (this.Name == a1.Name)
            {
                //animals are equal
                equality = true;
            }
            return equality;
        }

        public virtual string Walk()
        {
            return "the animal is walking";
        }
    }
}
