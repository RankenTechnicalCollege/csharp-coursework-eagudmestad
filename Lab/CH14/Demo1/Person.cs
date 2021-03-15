using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
   public class Person //known as the (super) class or (parent) class or (base) class
    {
        //Inheritance 
        //Create MEMBERS (class members are fields,properties,and methods)
        //that can be inherited by sub class or children classes
        //As you go UP the interitence hiarcy
        //Classes and Class Members become more GENERIC
        //As you go DOWN the interitence hiarcy
        //Classes and Class Membmers become more SPECIFIC

        //When you create Inheritance hiarchies
        //You create classes according to what they ARE
        //aka - Inheritance is known as an "IS-A" relationship
        //Animal >> Dog >> Pitbull


        private string _name;
        private string _ssn;

        public Person(string name,string ssn)
        {
            _name = name;
            _ssn = ssn;
        }

        public Person()
        {

        }

        //properties
        public string Name => _name;
        public string SSN => _ssn;

    }
}
