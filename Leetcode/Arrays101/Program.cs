using System;

namespace Arrays101
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 0, 1 };
            Console.WriteLine(FindMaxConsecutiveOnes(nums));
            
        }
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count = 0;
                }
                else
                {
                    count++;
                    if (count > result)
                    {
                        result = count;
                    }
                }
            }
            return result;
        }
    }
}