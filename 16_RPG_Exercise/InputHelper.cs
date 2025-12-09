using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RPG_Exercise
{
    public static class InputHelper
    {
        public static int ReadInt(int min, int max)
        {
            int userInput;
            while(!int.TryParse(Console.ReadLine(), out userInput) || userInput < min || userInput > max)
            {
                Console.WriteLine("Sorry, incorrect number.");
            }
            return userInput;
        }
        public static string ReadName(string name)
        {
            while (string.IsNullOrWhiteSpace(name) || int.TryParse(name, out _))
            {
                Console.Clear();
                Console.WriteLine("Enter a valid name.");
                name = Console.ReadLine();
            }
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            return name;
        }
    }
}
