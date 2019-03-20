using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Definition;

namespace LeetCode
{
    public class Solution
    {
        /// <summary>
        /// TwoSum
        /// </summary>
        /// <param name="nums">Given </param>
        /// <param name="target"></param>
        /// <returns></returns>
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

        /// <summary>
        /// AddTwoNumbers
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int x = 0;
            ListNode p, dummy = new ListNode(0);
            p = dummy;
            while (l1 != null | l2 != null | x != 0)
            {
                if (l1 != null)
                {
                    x += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    x += l2.val;
                    l2 = l2.next;
                }
                p.next = new ListNode(x % 10);
                x = x / 10;
                p = p.next;
            }
            return dummy.next;

        }
    }
}
