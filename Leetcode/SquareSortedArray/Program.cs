using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -4, -1, 0, 3, 10 };
            int[] result = new int[nums.Length];
            result = SortedSquares(nums);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

        }
        public static int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length].ToArray();
            result = nums.Select(p => p * p).ToArray();

            Array.Sort<int>(result, new Comparison<int>((i2, i1) => i2.CompareTo(i1)));
            return result;
        }
    }
}
