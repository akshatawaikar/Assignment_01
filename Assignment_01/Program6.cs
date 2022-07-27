using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program6
    {
        public string changeFirstAndLast(string s)
        {
            string newString = s[s.Length - 1]+ s.Substring(1,s.Length-2)+ s[0];
            return newString;
        }
    }
}
