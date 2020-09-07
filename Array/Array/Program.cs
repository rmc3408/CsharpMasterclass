using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] groupX = { 1, 2, 3, 4, 5, 6 };
            int[] groupA = new int[3];
            int[] groupB = new int[] { 10, 20 };

            groupA[0] = 6;
            groupA[1] = 8;
            groupA[2] = 1;

            //Print array and length in C#

            Console.WriteLine(groupA[1]);
            Console.WriteLine(groupA.Length);


            //Foreach method in C#

            int counter = 0;
            foreach (int item in groupA)
            {
                Console.WriteLine("index " + counter + " - element value "+ item);
                counter++;
            }

            //Exercise 01


            Console.Write("Enter a Value: ");
            var input = Console.ReadLine();
                      

            Console.WriteLine("Select a DataType to validate the input u have entered: ");
            int results = int.Parse(Console.ReadLine());

            string decision = "";
            switch (results)
            {
                case 1:
                    Console.WriteLine("You have entered a value: " + input);
                    Console.WriteLine($"It is a valid : String");
                    break;
                case 2:
                    Console.WriteLine("You have entered a value: " + input);
                    if (int.TryParse(input, out int result2))
                    {
                        decision = "valid";
                        Console.WriteLine($"It is a {decision} : Integer");
                    }
                    else
                    {
                        decision = "Invalid";
                        Console.WriteLine($"It is a {decision} : Integer");
                    }
                    break;
                case 3:
                    Console.WriteLine("You have entered a value: " + input);
                    if (bool.TryParse(input, out bool result3))
                    {
                        decision = "valid";
                        Console.WriteLine($"It is a {decision} : Boolean");
                    }
                    else
                    {
                        decision = "Invalid";
                        Console.WriteLine($"It is a {decision} : Boolean");
                    }
                    break;
                default:
                    break;
            }
            
           

            Console.ReadKey();

        }
    }
}
