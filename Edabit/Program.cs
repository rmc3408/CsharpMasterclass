using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(CreatePhoneNumber("abracadabra"));
        }
        public static int CreatePhoneNumber(string inputStr)
        {
            int num_vowels = 0;

            foreach (char i in inputStr)
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    num_vowels++;
                }
            }
            return num_vowels;


        }
    }
}