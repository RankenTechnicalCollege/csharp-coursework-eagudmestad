using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Order
    {
        //Instance Fields
        private string _name;
        private Sundae _sundae;
        private Soda _soda;

        //Properties
        public string Name => _name;
        public Soda Soda => _soda;

        public Sundae Sundae => _sundae;

        public double Price
        {
            get
            {
                double price = 0;
                if(_soda == null)
                {
                    //return just the Sundae price
                    price = _sundae.Price;
                }
                else if(_sundae == null)
                {
                    //return just the Soda price
                    price = _soda.Price;
                }
                else
                {
                    //return both
                    price = _sundae.Price + _soda.Price;
                }
                return price;
            }
        }
        
        //Methods
        public Order(String name,bool hasSundae, bool hasSoda)
        {
            _name = name;

            if(hasSundae)
            {
                _sundae = new Sundae();
            }

            if(hasSoda)
            {
                _soda = new Soda();
            }
        }
    }
}
