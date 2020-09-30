using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        // Create a base class Car with two properties HP and Color
        // Create a Constructor setting those two properties
        // Create a Method called ShowDetails() which shows the HP and Color of the car on the console
        // Create a Repair Method which writes "Car was repaired!" onto the console 
        // Create two deriving classes, BMW and Audi, which have their own constructor and have an aditional property
        // called Model. Also a private member called brand. Brand should be different in each of the two classes.
        // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.

        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new BMW("orange", 200, "M3", "family"),
                new Audi("yellow", 400, "A4", "sport")

            };
            foreach(Car item in cars)
            {
                if (item is Car)
                {
                    Console.WriteLine("\n"+ item + " is a Car");
                    if (item is BMW)
                    {
                        Console.WriteLine(item + " is a BMW");
                    }
                    if (item is Audi)
                    {
                        Console.WriteLine(item + " is a Audi");
                    }
                }

                Console.WriteLine(item.GetType()); 
                item.Repair();
                item.ShowDetails();
               
                Console.WriteLine("---------------------\n");
            }
            Car b23 = new BMW("white", 23, "channel", "rich");
            b23.SetCarIDInfo(301, "Drake");
            b23.GetInfoCar();

        }
    }
}
