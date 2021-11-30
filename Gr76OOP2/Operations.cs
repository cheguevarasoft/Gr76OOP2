using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr76OOP2
{
    class Operations
    {

        public int fakt(int eded)
        {
            int netice = 1;
            for (int i = 1; i <= eded; i++)
            {
                netice = netice * i;
            }

            return netice;
        }

        public int topla(int a, int b)
        {

            int result = a + b;
            return result;
        }

        public int topla(int a, int b, int c)
        {

            int result = a + b + c;
            return result;
        }

        public int topla(string a, string b)
        {

            int result = Convert.ToInt32(a) + Convert.ToInt32(b);
            return result;
        }


       


    }
}
