using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetGrind.Easy
{
    public static class ContainsDuplicateTwo
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    if (i - map[nums[i]] <= k)
                        return true;
                    else
                        map[nums[i]] = i;
                }
                else
                {
                    map.Add(nums[i], i);
                }
            }
            return false;
        }

    }
}
