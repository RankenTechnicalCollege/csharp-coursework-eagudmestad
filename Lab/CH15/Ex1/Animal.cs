using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    //The higher you are in the hiarchy the more generic
    //the classes become
    
    //Mark the class as abstract
    //Eventually, the classes may become so generic
    //That the only purpose they exist for is inheritance
    //In other words, you would never create an object from
    //that class, you would only use it to inherit from

    public class Animal : IComparable
    {
        //Inherit from a parent - Non private members are passed
        //down to the child class
        //Implement an interface - A behavior is enforced onto
        //the class

        private int _numLegs;

        public int NumLegs
        {
            //Abstract classes - Properties can also
            //have statements or blocks of code
            get
            {
                return _numLegs;
            }
            set
            {
                if(value > 4)
                {
                    _numLegs = 4;
                }
                else
                {
                    _numLegs = value;
                }
            }
        }


        public int AnimalId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            //return -1 if one object is less than the other
            //return 0 if they are equal
            //return +1 if one object is greater than the other
            Animal a2 = (Animal)obj;

            int returnVal;
            if(this.Age < a2.Age)
            {
                returnVal = -1;
            }
            else if(this.Age > a2.Age)
            {
                returnVal = 1;
            }
            else
            {
                returnVal = 0;
            }
            return returnVal;

            //When you implement this method, Array.Sort() 
            //will use it when sorting your custom objects

        }

        //call to this method would be a1.CompareTo(a2)

        public virtual string Walk()
        {
            //Methods can have a default implementation
            //aka method bodies can have statements
            return "the creature walks foward";
        }
    }
}
