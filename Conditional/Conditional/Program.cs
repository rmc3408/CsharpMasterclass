using System;

namespace Conditional
{
    internal class Program
    {



        static string password;
        static string username; // from challenge below
        public static void Login(string u, string p)
        {
            Console.Write("Enter username? ");
            string loginName = Console.ReadLine();

            if (loginName == u)
            {
                Console.Write("Enter password? ");
                if (p == Console.ReadLine())
                {
                    Console.Write("Login sucessful !");
                }
                else
                {
                    Console.Write("Wrong Password, Login failed !");
                }
            }
            else
            {
                Console.WriteLine("Wrong username");
            }
        }

        public static void Register()
        {

            Console.Write("Please, enter username? ");
            username = Console.ReadLine();
            Console.Write("Please, enter password? ");
            password = Console.ReadLine();


        }

        private static void Main(string[] args)
        {
            
            string input = "38";
            //bool success = int.TryParse(input, out int convertedInput);
            int temp;

            if (int.TryParse(input, out int convertedInput)) // (success = true)
            {
                temp = convertedInput;
                Console.WriteLine("Sucess convertion");
            }
            else
            {
                temp = 0;
                Console.WriteLine("Failed convertion or Wrong Characters");
            }


            if (temp < 2)
            {
                Console.WriteLine("Winter");
            }
            else if (temp > 25) // Only will run if above is false.
            {
                Console.WriteLine("Summer");
            }
            else
            {
                Console.WriteLine("Fall or Spring");
            }

            string user = "admin";
            if (temp > 0)
            {
                
                if (user.Equals("admin"))
                {
                    Console.WriteLine("positive temp and Admin");
                }
            }

            //To avoid Nested IF .... use AND &&.
            if (temp > 0 && user.Equals("admin"))
            {
                    Console.WriteLine("positive temp and Admin");
            }




            ///////////////////////////////////////////
            ///    challenge
            ///////////////////////////////////////////

            Register();
            Login(username, password);




            /// Switch

            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("too young");
                    break;
                case 25:
                    Console.WriteLine("Free pass");
                    break;
                               
                default:
                    Console.WriteLine("so, how old are u?");
                    age = int.Parse(Console.ReadLine());
                    break;
            }




            Console.Read();

        }
    }
}