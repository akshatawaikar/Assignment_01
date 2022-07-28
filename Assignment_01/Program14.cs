using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program14
    {
        public void intToString(int a, string s)
        {
            Console.WriteLine("Entered in function");
           string s1 = Convert.ToString(a);
           int  a1 = Convert.ToInt32(s);
           Console.WriteLine("Converted string is of {0} and Converted integer is {1}", s1, a1);
        }
    }
}
