using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
   public class Cat : Animal //Single parent inheritance in C#
    {
        public override string Walk()
        {
            return "The cat is walking";
        }
    }
}
