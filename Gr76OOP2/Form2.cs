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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Operations oper = new Operations();
        private void button1_Click(object sender, EventArgs e)
        {

            int eded = Convert.ToInt32(textBox1.Text);
           
            int fakt = oper.fakt(eded);
            label1.Text = fakt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

           int netice =  oper.topla(a, b);
            label1.Text = netice.ToString();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

           int netice =  oper.topla(a, b,c);

            label2.Text = netice.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;

            int netice = oper.topla(a, b);
            label3.Text = netice.ToString();
        }
    }
}
