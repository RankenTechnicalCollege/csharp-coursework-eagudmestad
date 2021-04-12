using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    public class Apparel
    {
        //Access Modifiers
        //Private - only available to the containing class
        //Public - Available to all classes
        //Protected - available to the containing class AND child classes
        protected string _color;
        
        public string Color
        {
            get { return _color; }
            set { 
                //apply business rules to the data
                if(value == null)
                {
                    _color = "red";
                }
                else if(value == "green")
                {
                    _color = "red";
                }
                else
                {
                    _color = value;
                }
                
            }
        }

    }
}
