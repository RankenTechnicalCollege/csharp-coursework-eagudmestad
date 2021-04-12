using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public sealed class Pitbull : Dog
    {
        //abstract is a keyword thats put on classes
        //HIGH UP in the heiarcy so you can not create instances
        //from them

        //sealed is a keyword thats put on classes
        //at the BOTTOM of the heiarcy
        //that will make sure NO other classes can inherit form them
    }
}
