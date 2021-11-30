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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        void CarTest(Car data)
        {
            MessageBox.Show(data.marca + "Test Success ");
        }

      


        Car aa = new Audi();
        private void button1_Click(object sender, EventArgs e)
        {
          
            aa.Start();
            aa.Stop();
        }

        Car tt = new Toyota();
        private void button2_Click(object sender, EventArgs e)
        {
          
            tt.Start();
            tt.Stop();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animal at = new Horse();
            at.GetVoice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal it = new Dog();
            it.GetVoice();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CarTest(tt);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IArifmetik oper = new Operation();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IMentiqi oper = new Operation();
            
        }

        string CutTek(int eded)
        {
            string netice = "";

            if (eded % 2 == 0)
            {
                netice = "Cut";
            }
            else
            {
                netice = "Tek";
            }

            return netice;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int eded = Convert.ToInt32(textBox1.Text);
            string a = CutTek(eded);
            label1.Text = a;
        }
    }
}
