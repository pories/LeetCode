using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetGrind.Easy
{
    public static class HammingDistance
    {

        //The Hamming distance between two integers is the number 
        //of positions at which the corresponding bits are different.


        public static int HammingDistanceAnswer(int x, int y)
        {
            return Convert.ToString(x ^ y, 2).Count(d => d == '1');

        }
    }
}
