using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            Console.Write("Write first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the symbol (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Write second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine("Result: " + result);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}