using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetGrind.Easy
{
    public static class Fizzbuzz
    {
        /*
        Write a program that outputs the string representation of numbers from 1 to n.
       But for multiples of three it should output “Fizz” instead of the number and for the multiples
       of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.
        */

        public static IList<string> FizzBuzzWork(int n)
        {
            IList<string> dave = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    dave.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    dave.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    dave.Add("Buzz");
                }
                else
                    dave.Add(i.ToString());
            }
            return dave;
        }



    }
}
