﻿using System;

namespace Conditional
{
    internal class Program
    {
        private static int highScore = 0;
        private static string highScorePlayer;
        private static string password;
        private static string username; // from challenge below

        public static void CheckScore(int score, string name)
        {
            if (score > highScore)
            {
                highScore = score;
                highScorePlayer = name;

                Console.WriteLine("The NEW highScore is " + score);
                Console.WriteLine("NEW highScore hoder by " + name);
            }
            else
            {
                Console.WriteLine("The old highScore is " + highScore
                    + " could not be broken and still held by " + highScorePlayer);
            }
        }

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

            ///////////////////////////////////////////
            ///    challenge
            ///////////////////////////////////////////

            CheckScore(20, "Raphael");
            CheckScore(10, "Luana");
            CheckScore(30, "Newton");

            ///////////////////////////////////////////
            ///   Ternary Condition
            ///////////////////////////////////////////

            //Ternary

            int celsius = -5;
            string state;

            state = celsius < 0 ? "Frozen" : "Liquid";

            state = celsius < 0 ? "frozen" : celsius > 100 ? "gas" : "liquid";
            Console.WriteLine(state);

            string inputTemp = "23";
            bool good = int.TryParse(inputTemp, out int tempC);

            if (good)
            {
                Console.WriteLine(tempC <= 15 ? "it is too cold" : tempC <= 28 ? "it is OK" : "it is hot");
            }
            else
            {
                Console.WriteLine("it is not a integer");
            }

            Console.Read();
        }
    }
}