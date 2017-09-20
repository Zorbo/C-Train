

using System;

namespace CSharpLearn
{

    // IN C# THE STATIC CLASS CANNOT HAVE A CONSTRUCTOR
    static class Utilities
    {
        public static void ColorfullWriteline(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.ReadLine();
        
        }


    }
}
