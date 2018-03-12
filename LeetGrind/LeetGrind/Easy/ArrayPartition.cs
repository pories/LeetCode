using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetGrind.Easy
{
    public static class ArrayPartition
    {
        #region This one works.
        //public static int ArrayPairSum(int[] nums)
        //{
        //    Array.Sort(nums);
        //    int sum = 0;
        //    for (int i = 0; i < nums.Length; i += 2)
        //    {
        //        sum += Math.Min(nums[i], nums[i + 1]);
        //    }

        //    return sum;
        //}
        #endregion

        #region This one works two, but slower.
        public static int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int sum = 0;
            for (var i = 0; i < nums.Length; i += 2)
            {
                sum += nums[i];
            }

            return sum;
        }
        #endregion

    }
}
