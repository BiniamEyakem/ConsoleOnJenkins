using System;

namespace ConsoleOnJenkins
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = "Guest";
            if (args.Length > 0 && !string.IsNullOrWhiteSpace(args[0]))
            {
                name = args[0];
            }
            
            Console.WriteLine($"Hello {name}!");
        }
    }
}
