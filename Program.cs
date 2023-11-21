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
            
            Console.WriteLine("Hello, I am GLaDOS \n please write password");
            string personChoice1 = Console.ReadLine();
            if ("cakelie" == personChoice1) 
            {
                Console.WriteLine("GLaDOS: welcome");
            } else if ("cakelie" != personChoice1) 
            {
                Console.WriteLine("INCORRECT");
                return;
            }
            
            Console.WriteLine("GLaDOS: what would you like me to do?");
            
            string personChoice = Console.ReadLine();

            if ("could you get me nerotoxin?" == personChoice)
            {
                Console.WriteLine("GLaDOS: " + "nerotoxin will be deployed in");
                Thread.Sleep(500);
                Console.Beep(550, 1000);
                Console.WriteLine("3");
                Thread.Sleep(500);
                Console.Beep(550, 1000);
                Console.WriteLine("2");
                Thread.Sleep(500);
                Console.Beep(550, 1000);
                Console.WriteLine("1");
                return;
            } else if ("start the turret factory" == personChoice)
            {
                Console.WriteLine("GLaDOS: " + "turret factory starting in");
                Thread.Sleep(500);
                Console.Beep(550, 1000);
                Console.WriteLine("3");
                Thread.Sleep(500);
                Console.Beep(550, 1000);
                Console.WriteLine("2");
                Thread.Sleep(500);
                Console.Beep(550, 1000);
                Console.WriteLine("1");
                return;
            } else if ("Bake a cake" == personChoice) {
                Console.WriteLine("GLaDOS" + "The cake will be made in");
                Thread.Sleep(500);
                Console.Beep(550, 1000);
                Console.WriteLine("3");
                Thread.Sleep(500);
                Console.Beep(550, 1000);
                Console.WriteLine("2");
                Thread.Sleep(500);
                Console.Beep(550, 1000);
                Console.WriteLine("1");
                return;
            }
            Console.ReadKey();
        }
    }
}