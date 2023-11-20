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
            Console.WriteLine("what would you like me to do?");
            
            string personChoice = Console.ReadLine();

            if ("could you get me nerotoxin?" == personChoice)
            {
                Console.WriteLine("GLaDOS:" + "nerotoxin will be deployed in \n 3 \n 2 \n 1");

            }
            Console.ReadKey();
        }
    }
}