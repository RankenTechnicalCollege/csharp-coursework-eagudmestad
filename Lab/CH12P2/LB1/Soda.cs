using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Soda
    {
        //Instance Fields
        public const double BASE_PRICE = 1.75;
        public const double FLAVOR_PRICE = .15;
        private SodaFlavor _flavor;
        private double _price;

        //Properties
        public SodaFlavor Flavor
        {
            get
            {
                return _flavor;
            }
        }

        public double Price => _price;
        

        //Methods
        
        public Soda()
        {
            _price += BASE_PRICE;
            _flavor = SodaFlavor.NONE;
        }

        public void AddFlavor(SodaFlavor f)
        {
            _flavor = f;
            _price += FLAVOR_PRICE;
        }
    }
}
