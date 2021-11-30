using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gr76OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {

            Insan ins = new Insan();
            //set
            ins.Name = textBox1.Text;
            ins.Surname = textBox2.Text;
            ins.BirthPlace = textBox3.Text;
            ins.BirthYear = Convert.ToInt32(textBox4.Text);

            //get
            label1.Text = ins.Name;
            label2.Text = ins.Surname;
            label3.Text = ins.BirthPlace;
            label4.Text = ins.BirthYear.ToString();

            int yash = ins.GetAge(ins.BirthYear);
            label5.Text = yash.ToString();


        }
    }
}
