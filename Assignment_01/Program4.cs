using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program4
    {
        public int[] table(int a)
        {
            int[] arr = new int[10];
            for(int i = 1; i <= 10; i++)
            {
                arr[i] = i * a;
            }

            return arr;
        }
    }
}
