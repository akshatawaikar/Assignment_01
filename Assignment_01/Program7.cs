using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program7
    {
        public bool PositiveNegative(int n1, int n2)
        {
            if((n1>=0 || n2>=0) && (n1<0 || n2 < 0))
            {
                return true;
            }
            return false;
        }
    }
}
