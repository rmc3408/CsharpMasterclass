namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Human person1 = new Human();
            person1.Intro();
            person1.fName = "Mike";
            person1.Intro();

            Human person2 = new Human();
            person2.Intro();
            person2.fName = "Luana";
            person2.Intro();

            Human person3 = new Human("Sunny", "Smith");
            person3.Intro();
            person3.fName = "Sissy";
            person3.Intro();

            Human person4 = new Human("Raph", "Molinaro", "brown", 38);
            person4.Intro();



        }
    }
}
