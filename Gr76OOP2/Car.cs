using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gr76OOP2
{
    class Car
    {

        public  string marca;
        public string model;
        public string coolor;
        public int speed;

        public virtual void Start()
        {
           MessageBox.Show("Car Starting");
        }

        public virtual void Stop()
        {
            MessageBox.Show("Car Stoping");
        }
    }
}
