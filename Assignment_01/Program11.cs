using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program11
    {
        public void formingArrayFromMiddleElement(int[] a1, int[] a2,int[] a3)
        {
            int[] newArray = { a1[1], a2[1], a3[1]};
            Console.Write("New Array formed is : ");
            for(int i = 0; i < 3; i++)
            {
                Console.Write(" {0} ",newArray[i]);
            }
           
        }
    }
}
