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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        enum HomeType
        {
            Bina = 100,
            Villa = 101,
            Bag = 102
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string hType = HomeType.Bina.ToString();
            MessageBox.Show(hType);

            int hType2 = Convert.ToInt32(HomeType.Bina);
            MessageBox.Show(hType2.ToString());
        }
    }
}
