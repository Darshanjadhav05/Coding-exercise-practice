using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_practice
{
    internal class Second_Largest_no
    {
        public static void second_large()
        {
            int[] arr = { 4, 3, 5, 111, 34, 2, 3, 4, 5,99 };
            int second_large = 0;
            int largest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    second_large = largest;
                    largest = arr[i];
                }
                else if (arr[i] < largest && second_large < arr[i]) {
                    second_large = arr[i];
                }
                }
            Console.WriteLine($"Largest Number is: {second_large} ");
            }
    }
}
