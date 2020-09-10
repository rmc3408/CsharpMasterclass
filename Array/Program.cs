using System;
using System.Collections;

namespace Array
{
    class Program
    {
        //Passing array as Argument in function.
        
        

        static void Main(string[] args)
        {

            

            //declare and initialize Arrays
            int[] groupX = { 1, 2, 3, 4, 5, 6 };
            int[] groupA = new int[3];
            int[] groupB = new int[] { 10, 20 };

            groupA[0] = 6;
            groupA[1] = 8;
            groupA[2] = 1;

            //declare and initialize ArrayLIST
            ArrayList myAL = new ArrayList();     //not limits pre-defined

            //Can store int, string , objects,...
            myAL.Add(39);
            myAL.Add("Raph");
            myAL.Add(80.6);
            myAL.Add("Hungry");
            myAL.Add(new int[]{ 1,2 }); 
            myAL.Add(80.5);
            myAL.Add(80.6);

            myAL.Remove(80.6); //remove by value
            myAL.RemoveAt(5); //remove by index

            foreach (object mini in myAL)
            {
                if(mini is int[])                           // IS is comparative between code!!
                {
                    Console.Write("The array location is ");
                }
                Console.WriteLine($"The value is {mini}");
            }

            
            //Passing array as Argument in function.
            int[] array1D = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Soma(array1D));

            static double Soma(int[] array)
            {
                int sum = 0;
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum = sum + array[i];
                    counter++;
                }
                double avg = (double)sum / counter;
                return avg;
            }


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

            // Jagged array and using random method class
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

            
            //challenge Argument Methods with array

            int[] happinessLevel = { 1, 2 };
            
            IsSunshineGood(happinessLevel);
            foreach (int item in happinessLevel)
            {
                Console.WriteLine(item);
            }

            static void IsSunshineGood(int[] level)
            {
                foreach (int item in level)
                {
                    int nl = item * 2;
                    Console.WriteLine(nl);
                }
                
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





            //Belongs to Exercise 01
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