using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program8
    {
        int longest;
        public string LongestWord(string str)
        {
            int max = 0;
            string [] words = str.Split(' ');
            for(int i=0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    longest = i;
                }

            }

            return words[longest];
        }
    }
}
