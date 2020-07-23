using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(CreatePhoneNumber(new int[]{1,2,3,4,5,6,7,8,9,0}));
        }
        public static string CreatePhoneNumber(int[] numbers)
        {
            String.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x=>(object)x).ToArray());


            string seq;
            string phone = "(";
            for (int i = 0; i < 10; i++)
            {
                seq = numbers[i].ToString();
                if(i == 3){
                    phone += ") ";
                }
                if(i == 6){
                    phone += "-";
                }
                phone += seq;
            }
            return phone;
        }


    }
}