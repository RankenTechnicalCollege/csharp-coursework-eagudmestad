using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Chair
    {
        //What is the name of the private pieces of data?
        //Instance Fields
        private string _chairColor;  //It's all about .... instance fields!!!!
        private int _numOfWheels;

        //DONT DO THIS!
        public double _chairHeight;
        
        //Constructor
        
        //Methods that have the SAME NAME as the class & NO return data type
        //Very similar to a mutator for multiple fields
        //Initalizer for multiple instance fields
        //You get a default construcor FOR FREE unless you code your own constructor
        public Chair(string color,int numOfWheels)
        {
            _chairColor = color;
            _numOfWheels = numOfWheels;
        }

        public Chair()
        {
            _chairColor = null;
            _numOfWheels = 0;
        }
        
        
        //Create things to put data IN to our instance fields
        //Like Mutators
        //Setters
        public void  SetChairColor(string color)
        {
            _chairColor = color;
        }

        public void SetNumWheels(int numOfWheels)
        {
            _numOfWheels = numOfWheels;
        }


        //Create things to retrieve data OUT of our instance fields
        //Like Accessors
        //Getters
        public string GetChairColor()
        {
            return _chairColor;
        }

        public int GetNumOfWheels()
        {
            return _numOfWheels;
        }

        //Property
        //Can Get or Set Data
        public String ChairColor
        {
            get
            {
                return _chairColor;
            }
            set
            {
                if(value == "purble")
                {
                    _chairColor = "black";
                }
                else
                { 
                    _chairColor = value;
                }
            }
        }

    }
}
