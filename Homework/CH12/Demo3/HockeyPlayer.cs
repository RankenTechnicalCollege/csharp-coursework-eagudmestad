using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    public class HockeyPlayer
    {
        //Instance Field
        private string _playerName;
        private int _playerNumber;

        //Constructor is just a method with the same name 
        //as the class
        //it has NO return type, not even NULL
        //public access modifier

        //default constructor is FREE
        //it costs you NOTHING
        //you don't have to code it........most of the time
        public HockeyPlayer()
        {
            _playerName = null;
            _playerNumber = 0;
        }

        public HockeyPlayer(string _playerName)
        {
            this._playerName = _playerName;
        }

        public HockeyPlayer(string name,int number)
        {
            _playerName = name;
            _playerNumber = number;
        }

        //Constructors can be used like MUTATORS
        //In other words, to set default values when 
        //constructing an object


        //Mutator
        public void SetPlayerName(string name)
        {
            //instance field equal to the parameter
            _playerName = name;
        }

        public void SetPlayerNumber(int num)
        {
            _playerNumber = num;
        }

        //Accessors
        public string GetPlayerName()
        {
            //returns the instance field
            return _playerName;
        }


        public int GetPlayerNumber()
        {
            return _playerNumber;
        }

       //Mutators and Accessors are the old school
       //way of working with instance fields
       //The newer technique in C# is a property
       
        //C# Property
        public string Name
        {
            //Properties can have 2 blocks in them
            //get block and a set block
            get
            {
                return _playerName;
            }
            set
            {
                _playerName = value;
            }
        }

        //EVERYTHING WORKS WITH INSTANCE FIELDS! 
        //to implement data hiding
        //Construtors, Mutators, Accessors, Properties
    }
}
