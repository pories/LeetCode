using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetGrind.Easy
{
    public static class JudgeCircle
    {
        //Initially, there is a Robot at position(0, 0). Given a sequence of its moves,
        //judge if this robot makes a circle, which means it moves back to the original place.

        //The move sequence is represented by a string. And each move is represent by a character. 
        //The valid robot moves are R (Right), L(Left), U(Up) and D(down). The output should be true or false representing whether the robot makes a circle.

        //Works
        #region
        public static bool JudgeCircleNow(string moves)
        {
            if (moves == null || moves == "")
            {
                return true;
            }

            // Keeps numbers of R/L/U/D in this order.
            int[] numberOfValues = new int[4];

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'R')
                {
                    numberOfValues[0]++;
                }
                else if (moves[i] == 'L')
                {
                    numberOfValues[1]++;
                }
                else if (moves[i] == 'U')
                {
                    numberOfValues[2]++;
                }
                else
                {
                    numberOfValues[3]++;
                }
            }

            return numberOfValues[0] == numberOfValues[1] && numberOfValues[2] == numberOfValues[3];

        }
        #endregion

    }
}
