using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gr76OOP2
{
    class Dog:Animal
    {
        public override void GetVoice()
        {
           MessageBox.Show("It sesi");
        }
    }
}
