using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student s1 = new Student("bob","111-111-1111");

            lblResult.Text = String.Format($"Student Info: {s1.Name}'s social is {s1.SSN}");
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teacher t1 = new Teacher("Gudmestad", "222-222-2222");


            lblResult.Text = String.Format($"Teacher Info:{t1.Name}'s social is {t1.SSN}");
        }
    }
}
