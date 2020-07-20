using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            /*
            ////////// FOR LOOPS ////////////
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 20; i+=2)
            {
                Console.WriteLine(i);
            }









            ///// DO WHILE //// When loop is under condition.

            int count = 1;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count < 6);


            
            int compTxt = 0;
            string wholeTxt = "";
            do
            {
                Console.Write("enter text?");
                string miniTxt = Console.ReadLine();
                wholeTxt += miniTxt + " ";
                
                int compMini = miniTxt.Length;
                compTxt += compMini;


            }while (compTxt < 30);
            Console.WriteLine("That is final text is " + wholeTxt);






            // While - check condiction first.
            int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }





            /////challenge on bus counter.
            Console.WriteLine("---------");
            int num = 0;
            string person = "";
            while(person.Equals(""))
            {
                Console.Write($"Person #{++num}");
                person = Console.ReadLine();
               
            }
            Console.WriteLine("\ntotal of people in the Bus is "+ --num);







            /////////////// break continue
            ///

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                if(i == 3)
                {
                    Console.Write(" = Break the whole loop.\n");
                    break;
                }

            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("continue next iterator");
                    break;
                }
                Console.WriteLine(i);

            }
            */
            // Challege average
            int totalGrade = 0;
            int grade;
            int sum = 0;

            do
            {
                Console.Write("enter grade? ");
                if (int.TryParse(Console.ReadLine(), out grade))
                {
                    if (grade == -1)
                    {
                        Console.WriteLine("exit");
                        break;
                    }
                    if (grade <= 0 || grade >= 20)
                    {
                        Console.WriteLine("Enter number between 0 to 20");    
                        continue;
                    }
                    sum += grade;
                    totalGrade++;

                }
                else
                {
                    Console.WriteLine("Invalid character");
                }

            } while (!grade.Equals(-1));

            int avg = sum / totalGrade;
            Console.WriteLine("the average is {0}", avg);



            Console.Read();
        }
    }
}
