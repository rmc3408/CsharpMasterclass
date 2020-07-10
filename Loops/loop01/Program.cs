using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            ////////// FOR LOOPS ////////////
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 20; i+=2)
            {
                Console.WriteLine(i);
            }

            ///// DO WHILE ////////////////

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


            } while (compTxt < 30);
            Console.WriteLine("That is final = " + wholeTxt);

            Console.Read();
        }
    }
}
