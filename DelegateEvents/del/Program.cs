using System;

namespace del
{
    internal class Program
    {
        /////////////////////////
        //     DELEGATES     /////
        /////////////////////////

        public delegate double PerformCalculation(double x, double y);

        //  delegate is assign method that follow SAME signature.... return double and have two double parameters.
        public static double Addition(double x, double y)
        {
            Console.WriteLine($"The sum is {x + y}");
            return x + y;
        }

        public static double Substraction(double x, double y)
        {
            Console.WriteLine($"The substraction is {x - y}");
            return x - y;
        }

        public static double Multiplication(double x, double y)
        {
            Console.WriteLine($"The multiplcation is {x * y}");
            return x * y;
        }

        public delegate string GetText(string txt);

        ///////////////////////////////////
        ////    Lambda Expression     /////
        ///////////////////////////////////

        static GetText benVindo = (string name) => { return "Bem vindo, " + name; };
        static GetText bemVindo = name => "Bem vindo, " + name;

        ///////////////////////////////////
        ////    Anonymous Methods     /////
        ///////////////////////////////////

        //REGULAR
        public static string Intro(string name)
        {
            return "hello, " + name;
        }

        // ANONYMOUS
        private GetText welcomeName = delegate (string nametxt)
          {
              return "Hello, " + nametxt;
          };

        public static void Display(GetText textDelegated)
        {
            Console.WriteLine(textDelegated("Ivan"));
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("\n--------   Calculation   --------\n");

            PerformCalculation getSum = Addition;
            Console.WriteLine(getSum(6, 4.5));

            PerformCalculation getSub = Substraction;
            Console.WriteLine(getSub(6, 4.5));

            /*********    Multi-cast     ***********/

            PerformCalculation operations = getSum + getSub;
            operations(3, 5);

            operations += Multiplication;
            operations(3, 5);

            operations -= Addition;
            operations(3, 5);
            operations -= getSub;
            operations(3, 5);

            //Dont do it: Give a logical fails, it runs but return last method.
            //Console.WriteLine(operations(3, 5));

            Console.WriteLine("\n\n\n");

            GetText welcomeMsg = Intro;
            Console.WriteLine(welcomeMsg("raph"));

            GetText welcomeName = delegate (string nametxt)
            {
                return "Hello, " + nametxt;
            };
            Console.WriteLine(welcomeName("Raphael"));

            // Call display method, send anonymous delegate function (one param and one string return)
            Display(welcomeName);

            Console.WriteLine("\n");

            Console.WriteLine(benVindo("Luana"));
            Console.WriteLine(bemVindo("Luana"));

        }
    }
}