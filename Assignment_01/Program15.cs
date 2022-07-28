using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program15
    {
        public string removeNonLetters(string s)
        {
            string cleanString = "";
            if (string.IsNullOrEmpty(s))
                return s;

          
            for (int i = 0; i<s.Length;i++)
            {
                int a = (int)s[i];
                if ((a > 64 && a <91) || (a >96 && a <123) || a == 32)
                    cleanString += (char)a;
            }
            return cleanString;

            
        }
    }
}
