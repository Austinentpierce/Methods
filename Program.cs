using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 56);


            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine(" Hello " + name + " you are " + age + " years old");
        }
    }
}
