using System;
using System.Dynamic;

namespace csharpfun 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GLaDOS";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.WriteLine("Hello, I am GLaDOS");
            Console.WriteLine("GLaDOS: what would you like me to do?");
            
            string personChoice = Console.ReadLine();

            if ("could you get me nerotoxin?" == personChoice)
            {
                Console.WriteLine("GLaDOS: " + "nerotoxin will be deployed in");
                Console.ReadKey();
                Console.WriteLine("3");
                Console.ReadKey();
                Console.WriteLine("2");
                Console.ReadKey();
                Console.WriteLine("1");
            }
            Console.ReadKey();
        }
    }
}