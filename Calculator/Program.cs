using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result = 0;
            char symbol;

            // restart bliver brugt af goto når man trykker på r
            restart:

            Console.Write("Tal 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tal 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Symbol +, -, /, *: ");
            symbol = Convert.ToChar(Console.ReadLine());

            //En switch der tager symbol og laver den til en string
            switch (symbol.ToString())
            {
                case "+":
                    Add(num1, num2);
                    break;
                case "-":
                    Minus(num1, num2);
                    break;
                case "*":
                    Multiply(num1, num2);
                    break;
                case "/":
                    Divide(num1, num2);
                    break;
            }

            Console.WriteLine("result: " + result);
            Console.WriteLine("To restart press R");

            //hivs man trykker på r keyen bliver consolen cleared og vi gå til restart
            if (Console.ReadKey().Key == ConsoleKey.R)
            {
                Console.Clear();
                goto restart;
            }
            Console.WriteLine();
        }

        //Metode der ganger tal "a" og tal "b" og returnere det.
        static double Multiply(int a, int b)
        {
            return a * b;
        }

        //Metode der dividere tal "a" og tal "b" og returnere det.
        static double Divide(double a, double b)
        {
            return a / b;
        }

        //Metode der lægger tal "a" og tal "b" sammen og returnere det.
        static double Add(double a, double b)
        {
            return a + b;
        }

        //Metode der trækker tal "a" fra tal "b" og returnere det.
        static double Minus(double a, double b)
        {
            return a - b;
        }
    }
}