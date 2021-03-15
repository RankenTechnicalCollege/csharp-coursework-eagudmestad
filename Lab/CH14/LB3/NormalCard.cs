using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public class NormalCard : ICard
    {
        //Instance Fields
        private string _name;
        private System.Drawing.Image _image;
        private double _value;

        //Constructor
        public NormalCard(string name,System.Drawing.Image image,double value)
        {
            _name = name;
            _image = image;
            _value = value;
        }


        public string Name => _name;

        public Image Picture => _image;

        public double Value => _value;

        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = _image;
            picture.BackColor = Color.SlateGray;
            label.Text = _name;
            label.ForeColor = Color.Black;
            label.Font = new Font("Microsoft Sans Sarif", 15.75f);
        }
    }
}
