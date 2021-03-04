using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Sundae
    {
        //Instance Fields
        public const double BASE_PRICE = 4.5;
        public const double TOPPING_PRICE = .5;
        private SundaeTopping[] _toppings;
        private int _toppingCount;
        private double _price;

        //Properties
        public int ToppingCount
        {
            get
            {
                return _toppingCount;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        //Methods
        //Constructor is a method w the same name as the class
        //They DONT have a return data type - not even VOID
        public Sundae()
        {
            //Whenever a Sundae is created, what needs to be done
            //w the instance fields?
            _toppingCount = 0;
            _price += BASE_PRICE;
            _toppings = new SundaeTopping[2];
            _toppings[0] = SundaeTopping.NONE;
            _toppings[1] = SundaeTopping.NONE;
        }
        
        public SundaeTopping GetTopping(int index)
        {
            return _toppings[index];
        }

        public void AddTopping(SundaeTopping t)
        {
            //add the topping to the toppings array
            _toppings[_toppingCount] = t;
            //increase the topping count
            _toppingCount++;
            //increase the price
            _price += TOPPING_PRICE;
        }
    }
}
