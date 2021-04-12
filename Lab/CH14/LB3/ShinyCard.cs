using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public class ShinyCard : ICard
    {
        //Instance Fields
        private string _name;
        private System.Drawing.Image _image;
        private double _value;
        private System.Drawing.Color _backColor;
        private System.Drawing.Color _foreColor;

        public ShinyCard(string name,System.Drawing.Image image,double value,System.Drawing.Color backColor,System.Drawing.Color foreColor)
        {
            _name = "shiny " + name;
            _image = image;
            _value = value;
            _backColor = backColor;
            _foreColor = foreColor;
        }

        public string Name => _name;

        public Image Picture => _image;

        public double Value => _value;

        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = _image;
            picture.BackColor = _backColor;

            label.ForeColor = _foreColor;
            label.Text = _name;
            
        }
    }
}
