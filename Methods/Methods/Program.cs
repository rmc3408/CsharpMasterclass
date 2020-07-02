using System;

namespace Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WriteWord();
            WriteWord("Method called with one parameter");
            Console.WriteLine("This result from return of method = " + AddNumbers(2, 3));
            

            Console.WriteLine(AddNumbers((AddNumbers(1, 2)), (AddNumbers(2, 3))));
            Console.WriteLine(Division(23, 13));



            //    challenge
            string f1 = "George";
            string f2 = "Chloe";
            string f3 = "John";

            GreetFriend(f1);
            GreetFriend(f2);
            GreetFriend(f3);
            GreetFriend(f1, f2, f3);



            //    User input     /////

            Console.WriteLine(Calculate());



            //    Try Catch     /////

            TryCalculate();
            DivisionTry();
            Console.ReadKey();




            /////////////////////////
            //    Operators     /////
            /////////////////////////
            ///
            int n4 = 50;
            Console.WriteLine(-n4); //output -50
            
            bool isSunny = true;
            Console.WriteLine(!isSunny); //output false

            int inc = 0;
            inc++;
            Console.WriteLine(inc); //output 1
            Console.WriteLine(inc++); //output 1 - Output is 1, but will add 1, finally 2.
            Console.WriteLine(++inc); //output 1 - Add 1 plus 2, then output 3.




        }

        //public - all access
        //static - to be in same static group method.
        public static void WriteWord()
        {
            Console.WriteLine("Called Method with no parameter word");
        }

        public static void WriteWord(string s)
        {
            Console.WriteLine(s);
        }

        public static int AddNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("This print is from inside method AddNumber()");
            return sum;
        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hello {0}, my friend!", name);
        }

        public static void GreetFriend(string n, string m, string o)
        {
            Console.WriteLine("Hello {0}, my friend!", n);
            Console.WriteLine("Hello {0}, my friend!", m);
            Console.WriteLine("Hello {0}, my friend!", o);
        }

        public static int Calculate()
        {
            Console.WriteLine("Number 01 = ");
            string myNum1 = Console.ReadLine();
            Console.WriteLine("Number 02 = ");
            string myNum2 = Console.ReadLine();

            int cNum1 = int.Parse(myNum1);
            int cNum2 = int.Parse(myNum2);

            return cNum1 + cNum2;
        }

        public static void TryCalculate()
        {
            Console.Write("Number 01 = ");
            string myNum1 = Console.ReadLine();
            
            try
            {
                int cNum1 = int.Parse(myNum1);
                Console.WriteLine(cNum1);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Catched No Number entered Expection= null value");
            }
            catch (FormatException)
            {
                Console.WriteLine("Catched Format Expection = Non-integer character");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverFlow Expection = Number too long");
            }
            finally
            {
                //Use to close connection, or close FileStream.
                Console.WriteLine("Final block if error or Not!!");
            }


        }

        public static void DivisionTry()
        {
           
            int cNum1 = 22;
            int cNum2 = 0;

            try
            {
                int div = cNum1 / cNum2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException = NOT divide by ZERO");
            }
        }


    }
}