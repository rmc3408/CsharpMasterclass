using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // Create a base class Car with two properties HP and Color
    // Create a Constructor setting those two properties
    // Create a Method called ShowDetails() which shows the HP and Color of the car on the console
    // Create a Repair Method which writes "Car was repaired!" onto the console 
    class Car
    {
        protected int HP { get; set; }
        protected string Color { get; set; }

        protected CarIDInfo info = new CarIDInfo();
        public void SetCarIDInfo(int id, string owner)
        {
            info.IDNum = id;
            info.Owner = owner;
        }
        public void GetInfoCar()
        {
            Console.WriteLine("the car has ID:{0} and owned by {1}", info.IDNum, info.Owner );
        }

        public Car(string co, int hp)
        {
            HP = hp;
            Color = co;
        }

        //virtual allow to override
        public virtual void ShowDetails()
        {
            Console.WriteLine("The color is {0} and speed force is {1}", Color, HP);
        }
        public virtual void Repair()
        {
            Console.WriteLine("The car was repaired");
        }


    }
}
