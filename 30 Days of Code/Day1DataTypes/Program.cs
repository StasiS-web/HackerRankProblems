using System;

namespace Day1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            // Read and save an integer, double, and String to your variables.
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string t = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            int sum = i + a;
            Console.WriteLine(sum);

            // Print the sum of the double variables on a new line.
            double result = d + b;
            Console.WriteLine(result);

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + t);
        }
    }
}
