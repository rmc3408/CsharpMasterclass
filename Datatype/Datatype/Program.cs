using System;

namespace Datatype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Hello");

            //The smallest datatype, only for few numbers.
            sbyte codeNumber = 1;
            Console.WriteLine(codeNumber);

            //Show error - only operation with int or more complex data types;
            //sbyte num1 = 10;
            //sbyte num2 = 5;
            //sbyte sum = num1 + num2;

            int num1 = 10;
            int num2 = 5;
            int sum = num1 + num2;
            Console.WriteLine("number 01 is " + num1 + " ,number 2 is " + num2 + " ,sum = " + sum);

            float f1 = 3.999F;
            double f2 = 3.5986;

            string myStr = "molinaro";
            Console.WriteLine("My surname is " + myStr);
            Console.WriteLine(myStr.ToUpper());

            //A data type is a value type if it holds a data value within its own memory space.
            //It means the variables of these data types directly contain values.

            //A reference type doesn't store its value directly,
            //it contains a pointer to another memory location that holds the data.

            /** Namespace, Classes, interfaces and methods and properties in PascalCase
             *  datatype variables in CamelClasses.
             */

            double myDouble = 13.97;
            int myInt = (int)myDouble; //explicit convert... cut all decimals. Keep = 13
            Console.WriteLine(myInt);

            //type Conversion.
            string myfloatConverted = f1.ToString();
            string mydoubleConverted = f2.ToString();

            Console.WriteLine(myfloatConverted);
        }
    }
}