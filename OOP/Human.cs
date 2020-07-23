using System;

namespace OOP
{
    class Human
    {

        //member variable = public = Acessible in this class or outside from object.
        public string fName = "human";
        //member variable = default is private = Only avaliable this class
        string lastName = "Doe";
        private string eyecolor;
        private int age;


        //constructor with 4 arguments.
        public Human(string fn, string ln, string e, int a)
        {
            this.fName = fn;
            this.lastName = ln;
            this.eyecolor = e;
            this.age = a;
        }

        //Constructor with 2 arguments
        public Human(string fn, string lastName)
        {
            fName = fn;
            this.lastName = lastName;
        }

        //Constructor with 0 arguments, just to instantiate a object
        public Human()
        {

        }

        //Method
        public void Intro()
        {
            Console.WriteLine("Hi, it is {0} {1} and age = {2}"
                , fName, lastName, age);
        }


    }
}
