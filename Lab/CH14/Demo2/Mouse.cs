using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Mouse : Animal
    {
        //As you go DOWN the heiarchy - classes become more SPECIFIC
        //These more specific classes CAN contain unique 
        //methods or properites

        public Mouse(string name,int age,int numLegs,bool hasDisease) : base(name,age,numLegs)
        {
            HasDisease = hasDisease;
        }

        public bool HasDisease { get; set; }

        //write a more specific ToString
        public override string ToString() 
        {
            return base.ToString() + String.Format($" has disease:{HasDisease}");
        }
    }
}
