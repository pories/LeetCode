using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetGrind.Easy
{
    public static class Palindrome
    {

        //Determine whether an integer is a palindrome. Do this without extra space.
        //palindrom number

        public static bool IsPalindrome(int x)
        {
            bool IsPalindrome;
            string dave = x.ToString();
            string str = new String(x.ToString().Reverse().ToArray());
            if (dave == str)
            { IsPalindrome = true; }
            else
            { IsPalindrome = false; }
            return IsPalindrome;
        }
    }
}
