using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumbersEvenDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 586, 1901, 22482, 771 };
            int[] nums2 = new int[] { 12, 345, 2, 6, 7896 };
            Console.WriteLine(FindNumbers(nums1));

        }
        public static int FindNumbers(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                string num = nums[i].ToString();
                bool isEven = num.Length % 2 == 0;
                if (isEven)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
