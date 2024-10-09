using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_practice
{
    internal class Largest_no
    {
        public static void LargestNo()
        {
            int[] arr = { 4, 3, 5, 111, 34, 2, 3, 4, 5, 99};
            int large = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > large)
                {
                    large = arr[i];
                }
            }
            Console.WriteLine($"Largest Number is: {large} ");
        }
    }
}
