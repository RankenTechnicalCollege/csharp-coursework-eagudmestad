using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
   public class Bat
    {
        //instance fields
        private string batBrand;
        private double batWeight;

        //Modified and accessed with public methods
        //mutators - methods that modify instance fields
        //Writing data into the instance fields
        public void setBatBrand(string brand)
        {
            //whats changing is on the LEFT of the equals
            batBrand = brand;
        }

        public void setBatWeight(double weight)
        {
            if(weight > 11)
            {
                //cork in the bat and do not allow it! 
                batWeight = -1;
            }
            else
            { 
                //controlling modification of the data
                batWeight = weight;
            }
        }

        //READ
        //accessors
        public string getBatBrand()
        {
            //return the instance field
            return batBrand;
        }

        public double getBatWeight()
        {
            return batWeight;
        }
    }
}
