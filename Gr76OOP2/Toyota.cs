using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gr76OOP2
{
    class Toyota:Car
    {

        public string tPackage;

        public override void Start()
        {
            MessageBox.Show("Toyota Starting");
        }

        public override void Stop()
        {
            MessageBox.Show("Toyota Stoping");
        }
    }
}
