using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program12
    {
        public bool palindrome(string s)
        {
            string revs = "";
            
          
            for (int i = s.Length - 1; i >= 0; i--)  
            {
                revs += s[i];
            }
            return revs == s;
        }
    }
}
