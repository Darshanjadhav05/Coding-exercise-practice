using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_practice
{
    internal class Sorted_Rotated
    {
       public static bool Check(int[] nums)
        {
            int count = 0;
            int n = nums.Length;

            for (int i = 1; i < n; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    count++;
                }
            }

            if (nums[n - 1] > nums[0])
            {
                count++;
            }

            return count <= 1;
        }
    }
}
