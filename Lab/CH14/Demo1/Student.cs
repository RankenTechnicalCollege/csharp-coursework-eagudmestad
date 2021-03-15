using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Student : Person
    {
        //base means "parent constructor with 2 argments"
        public Student(string name,string ssn) : base(name,ssn)
        {

        }
    }
}
