using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            Hecarim h1 = new Hecarim();
            h1.ChampionName = "Hecarim";

            lblResult.Text = h1.RAbility();
            //Dog d1 = new Dog();
            //d1.Age = 100;
            //d1.Name = "Fido";


            //Cat c1 = new Cat();

            //DoSomething(c1);

            Animal[] myZoo = new Animal[4];
            //Object Initalizers
            myZoo[0] = new Animal() { Age = 100, Name = "Fido" };
            myZoo[1] = new Animal() { Age = 0, Name = "Eliott" };
            myZoo[2] = new Animal() { Age = 50, Name = "Tam Tam" };
            myZoo[3] = new Animal() { Age = 25, Name = "Zig" };

            Array.Sort(myZoo);


            //for (int i = 0; i < myZoo.Length; i++)
            //{
            //    lblResult.Text += myZoo[i].Name + "\n";
            //}

            foreach (Animal a in myZoo)
            {
                lblResult.Text += a.Name + "\n";
            }


        }

        //You can upcast your objects into their parents
        public void DoSomething(Animal a1)
        {
            //Polymorphism - (many forms)
            //An object can behave differently depending 
            //the the data type it references
            //Object Oriented Principle 
            lblResult.Text = a1.Walk();
        }
    }
}
