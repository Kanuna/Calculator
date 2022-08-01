using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Multiply(6, 9));
            Console.WriteLine(Divide(6, 9));
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Minus(4, 2));
            WriteThis();

        }

        static double Multiply(int a, int b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Minus(double a, double b)
        {
            return a - b;
        }

        static void WriteThis()
        {
            Console.WriteLine("This");
        }
    }
}