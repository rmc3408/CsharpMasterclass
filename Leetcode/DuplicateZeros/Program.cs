using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 0, 2, 3, 0, 4, 5, 0 };
            int[] arr2 = { 0, 0, 0, 0, 0, 0, 0 };
            int[] arr3 = { 8,4,5,0,0,0,0,7 };
            DuplicateZeros(arr2);
        }
        public static void DuplicateZeros(int[] arr)
        {
            int[] array = new int[arr.Length];
            int countNew = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (countNew >= arr.Length)
                {
                    int count = 0;
                    foreach (int a in array)
                    {
                        arr[count] = a;
                        count++;
                    }
                    break;
                }
                if (arr[i] != 0)
                {
                    array[countNew] = arr[i];
                    countNew++;
                }
                else if (arr[i] == 0)
                {
                    array[countNew] = 0;
                    if(countNew+1 >= arr.Length)
                    {
                        countNew++;
                        break;
                    }
                    array[countNew + 1] = 0;
                    countNew+=2;
                }
                
            }

        }
    }
}
