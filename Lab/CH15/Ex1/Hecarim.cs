using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    //You can only inherit from a single parent
    //However you can implement many interfaces
    class Hecarim : Champion, IAbility, IComparable
    {
        public string Save 
        {
            get
            {
                return "saved";
            }
            set
            {
                //DoSomething
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public string EAbility()
        {
            return "swipes his sword";
        }

        public string QAbility()
        {
            throw new NotImplementedException();
        }

        public string RAbility()
        {
            return "Hecarim's Ultimate Cool Ability";
        }

        public string WAbility()
        {
            throw new NotImplementedException();
        }
    }
}
