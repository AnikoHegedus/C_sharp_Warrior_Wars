using System;
namespace IntroToOOP
{
    static class Utilities
    {
        public static void ColorfulWhiteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}