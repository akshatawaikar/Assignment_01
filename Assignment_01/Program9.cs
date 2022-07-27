using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program9
    {
        public int sumOfDigitsOfInteger(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                int temp = a % 10;
                sum += temp;
                a = a / 10;
            }
            return sum;
        }
    }
}
