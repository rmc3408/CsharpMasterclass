using System;

namespace Conditional
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            string input = "38";
            //bool success = int.TryParse(input, out int convertedInput);
            int temp;

            if (int.TryParse(input, out int convertedInput)) // (success = true)
            {
                temp = convertedInput;
                Console.WriteLine("Sucess convertion");
            }
            else
            {
                temp = 0;
                Console.WriteLine("Failed convertion or Wrong Characters");
            }


            if (temp < 2)
            {
                Console.WriteLine("Winter");
            }
            else if (temp > 25)
            {
                Console.WriteLine("Summer");
            }
            else
            {
                Console.WriteLine("Fall or Spring");
            }






        }
    }
}