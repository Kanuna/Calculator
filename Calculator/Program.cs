using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(1, 2));
            Console.WriteLine(Divide(2, 3));
        }

        static double Multiply(int a, int b)
        {
            
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
