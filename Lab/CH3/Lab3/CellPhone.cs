using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    //class is the blueprint for the object
    //aka the cookie cutter
    public class CellPhone
    {
        //Classes have MEMBERS
        //MEMBERS are Methods,Properties, or Events


        //Property
        //Piece of data about the class
        //aka a cell phone manufacturer
        //maybe cell phone size
        //maybe cell phone color
        //maybe cell type of glass
        public string Manufacturer { get; set; }

        public int SerialNumber { get; set; }
        //Method has an identifier
        //Method has parenthesis
        //Method is a behavior of the class (What the class can DO)
        public string Ring()
        {
            return "plays Rhiana music";  
        }
    }
}
