using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Item
    {
        //Instance Fields
        private string _name;
        private string _upc;
        private double _storePrice;
        private double _costPerCase;
        private int _unitsPerCase;
        private string _distributor;

        //Insert Data into the fields
        //Constructor or Setter methods or Properties
        public Item(string name,string upc,double storePrice,double costPerCase,int unitsPerCase,string distributor)
        {
            _name = name;
            _upc = upc;
            _storePrice = storePrice;
            _costPerCase = costPerCase;
            _unitsPerCase = unitsPerCase;
            _distributor = distributor;
        }

        //Read Data from the fields
        //Getter methods or Properties
        public string Name
        {
            //read only property which means it only has a get block
            get
            {
                return _name;
            }
        }

        public string Upc
        {
            get { return _upc; }
        }

        public double StorePrice

        {
            get
            {
                return _storePrice;
            }
            set
            {
                _storePrice = value;
            }
        }

        public double CostPerCase => _costPerCase;

        public int UnitsPerCase => _unitsPerCase;

        public String Distributor => _distributor;

    }
}
