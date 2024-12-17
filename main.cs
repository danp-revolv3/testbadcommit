using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AskAndPrintName();
        }

        static void AskAndPrintName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
