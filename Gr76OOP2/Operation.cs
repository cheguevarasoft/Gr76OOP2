using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr76OOP2
{
    class Operation : IArifmetik, IMentiqi
    {
        public bool CutTek(int eded)
        {
            bool netice = false;

            if (eded%2  == 0)
            {
                netice = true;
            }

            return netice;
        }

        public int topla(int a, int b)
        {
            int netice = a + b;
            return netice;
        }
    }
}
