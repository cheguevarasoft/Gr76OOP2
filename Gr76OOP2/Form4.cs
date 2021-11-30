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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        enum CardType
        {
            Classic = 100,
            Gold = 101,
            Platinium = 102
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            Main mn = new Main();
            mn.yaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string card = CardType.Platinium.ToString();

            MessageBox.Show(card);

            int card1 = Convert.ToInt32(CardType.Platinium);
            MessageBox.Show(card1.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
