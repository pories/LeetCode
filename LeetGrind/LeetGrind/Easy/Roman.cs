using System;
using System.Collections; //added for hashtable.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetGrind.Easy
{
    public static class Roman
    {
        #region
        //Given a roman numeral, convert it to an integer.
        //Input is guaranteed to be within the range from 1 to 3999.
        public static int RomanToInt(string s)

        {

            if (s.Length == 0)
                return 0;

            Hashtable ht = new Hashtable();

            ht.Add('I', 1);
            ht.Add('V', 5);
            ht.Add('X', 10);
            ht.Add('L', 50);
            ht.Add('C', 100);
            ht.Add('D', 500);
            ht.Add('M', 1000);

            int i = 0;
            int number = 0;
            while (i < s.Length)
            {
                if (i + 1 < s.Length && (int)ht[char.ToUpper(s[i])] < (int)ht[char.ToUpper(s[i + 1])])
                {
                    number += (int)ht[char.ToUpper(s[i + 1])] - (int)ht[char.ToUpper(s[i])];
                    i += 2;
                }

                else
                {
                    number += (int)ht[char.ToUpper(s[i])];
                    i++;
                }
            }
            return number;
        }
        #endregion
    }

}