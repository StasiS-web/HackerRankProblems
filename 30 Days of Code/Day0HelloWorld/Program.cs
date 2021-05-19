using System;

namespace Day0HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            string input = Console.ReadLine();

            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");
            Console.WriteLine(input);
        }
    }
}
