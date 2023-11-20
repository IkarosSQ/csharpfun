using System;

namespace csharpfun 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GLaDOS";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.WriteLine("Hello, Aperture enrichment center");
            Console.WriteLine("what would you like me to do?");
            
            Console.ReadLine();
            Console.WriteLine("Sorry i dont know what you're wanting me to do.");

            Console.ReadKey();
        }
    }
}