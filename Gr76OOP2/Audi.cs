using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gr76OOP2
{
    class Audi:Car
    {

       public string aPackage;

        public override void Start()
        {
           MessageBox.Show("Audi Starting");
        }

        public override void Stop()
        {
            MessageBox.Show("Audi Stoping");
        }

    }
}
