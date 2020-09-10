using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[] { 99, 67, 82, 70 }; //same datatype,  limited number, immutable
            
            List<int> myL = new List<int> { 1, 2, 3, 4 }; //same datatype, NOT limited size.
            myL.Add(8);
            myL.Add(32);

            myL.Sort();

            bool answer = myL.Contains(4);

            int position4 = myL.FindIndex(p => p == 32);

            myL.ForEach(i => Console.WriteLine(i * 2) );

            /// ArrayList
            ArrayList myAL = new ArrayList();  // Any data type and any size
            myAL.Add(23);
            myAL.Add("Ivan");
            myAL.Add('C');
            myAL.Add(new Numb() { num = 400 });

            foreach (object item in myAL)
            {
                Console.WriteLine(item);
            }
            
        }
    }
    class Numb
    {
        public int num { get; set; }

        public override string ToString()
        {
            return num.ToString();
        }
    }
}
