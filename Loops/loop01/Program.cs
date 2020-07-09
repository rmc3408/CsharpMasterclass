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




            Console.Read();
        }
    }
}
