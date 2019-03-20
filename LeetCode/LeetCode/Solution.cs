using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var mapping = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var key = target - nums[i];
                if (mapping.ContainsKey(key))
                {
                    return new int[] { mapping[key], i };
                }
                else
                {
                    if (!mapping.ContainsKey(nums[i]))
                    {
                        mapping.Add(nums[i], i);
                    }
                }
            }
            throw new Exception("target not found.");
        }
    }
}
