using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class OculusRift
    {
        //instance fields
        private string _color;
        private double _price;
        private string _version;

        //Constructor
        //Is a way to set the instance fields
        //when you instantiate an object
        public OculusRift(string color, string version)
        {
            _color = color;
            _version = version;
            _price = _version == "rift_s" ? 300 : 200;
            //if(_version == "rift_s")
            //{
            //    _price = 300;
            //}
            //else
            //{
            //    _price = 200;
            //}
        }

        //Read & Write Property
        public String Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        //Read & Write property
        public String Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
                _price = _version == "rift_s" ? 300 : 200;
            }
        }

        //READ ONLY Price property
        public double Price
        {
            get
            {
                return _price;
            }
        }
    }
}
