using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Letter
    {
        //Instance Fields
        protected string _recipient;
        protected DateTime _sentDate;

        //Constructor
        public Letter(string recipient,DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }

        //Read Only Properties
        public string Recipient
        {
            get
            {
                return _recipient;
            }
        }

        public DateTime SentDate => _sentDate;

        public virtual double Price
        {
            get
            {
                return .5;
            }
        }

        //A ToString() method returns relevant information
        //from a letter
        //in this case, it's the recipient, sent date, and Price
        public override string ToString()
        {
            //Can use the instance fields OR the properties
            return String.Format($"{_sentDate:ddMMMyyyy},{_recipient},{Price:C}");
        }

    }
}
