using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            //declare and initialize Arrays
            int[] groupX = { 1, 2, 3, 4, 5, 6 };
            int[] groupA = new int[3];
            int[] groupB = new int[] { 10, 20 };

            groupA[0] = 6;
            groupA[1] = 8;
            groupA[2] = 1;


            //Jagged Array

            int[][] jArray = new int[][]
            {
                new int[]{1,2,3,4,5},
                new int[]{10,20, 30, 40, 50},
                new int[]{7, 11}
            };

            Console.WriteLine($"The middle second array value is {jArray[1][2]}");

            foreach (int[] item in jArray)
            {
                Console.WriteLine($"The value is {item}");
                foreach (int mini in item)
                {
                    Console.WriteLine($"The value is {mini}");
                }

            }

            
            string[][] friend = new string[3][]
            {
                new string[2]{ "Launa", "Raph" },
                new string[2]{ "Sonia", "Severino" },
                new string[2]{ "Maria", "Antonio" }
            };
            Random rnd = new Random();
            Console.WriteLine("\n\nI would like to introduce {0} to {1}"
                , friend[rnd.Next(3)][rnd.Next(2)], friend[rnd.Next(3)][rnd.Next(2)]);



            //multidimensional Array

            int[,] array2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(array2D[1, 1]);
            Console.WriteLine(array2D[2, 0]);



            //Print array and length in C#

            Console.WriteLine(groupA[1]);
            Console.WriteLine(groupA.Length);


            //Foreach method in C#

            int counter = 0;
            foreach (int item in groupA)
            {
                Console.WriteLine("index " + counter + " - element value " + item);
                counter++;
            }

            //Exercise 01


            Console.Write("Enter a Value: ");
            var input = Console.ReadLine();


            Console.WriteLine("Select a DataType to validate the input u have entered: ");
            int results = int.Parse(Console.ReadLine());

            string decision = string.Empty;
            switch (results)
            {
                case 1:
                    Console.WriteLine("You have entered a value: " + input);
                    if (isAlphabetic(input))
                    {
                        decision = "valid";
                        Console.WriteLine($"It is a {decision} : String");
                    }
                    else
                    {
                        decision = "Invalid";
                        Console.WriteLine($"It is a {decision} : String");
                    }
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
            static bool isAlphabetic(string value)
            {
                foreach (char val in value)
                {
                    if (!char.IsLetter(val))
                    {
                        return false;
                    }
                }
                return true;
            }


            Console.ReadKey();

        }
    }
}