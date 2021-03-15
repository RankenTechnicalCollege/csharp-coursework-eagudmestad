using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public interface ICard
    {
        //Interface Method
      void ShowCard(PictureBox picture, Label label);

        string Name { get; }

        Image Picture { get; }

        double Value { get; }

    }
}
