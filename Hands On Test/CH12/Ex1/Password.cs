using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Password
    {
        private string _raw;
        private string _hash;

        //Overloaded Constructors
        public Password()
        {

        }

        public Password(string raw,string hash)
        {
            _raw = raw;
            _hash = hash;
        }

        //Read Only properties
        public string Raw
        {
            get
            {
                return _raw;
            }
        }

        public string Hash => _hash; //Lambda operator

    }
}
