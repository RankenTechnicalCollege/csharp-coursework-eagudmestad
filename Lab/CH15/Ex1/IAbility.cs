using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public interface IAbility
    {
        //Champions with 4 abilities
        //Q ability when the user presses Q
        //W ability
        //E ability
        //R ability
        string Save
        {
            get;
            set;
        }

        //In an interface, you only declare the method
        //signature
        string QAbility();

        string WAbility();

        string EAbility();

        string RAbility();

    }
}
