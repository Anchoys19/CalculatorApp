using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            checkConverting(out num1, out operation);
            checkNum2(out num2);

            double result = switchOperation(num1, num2, operation);

            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }

        static bool checkConvertToDouble(string arg)
        {
            try
            {
                double num = Convert.ToDouble(arg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static bool checkOperation(char symb)
        {
            if (symb == '+' || symb == '-' || symb == '*' || symb == '/')
            {
                return true;
            }

            return false;
        }

        static void checkConverting(out double num1, out char operation)
        {
            while (true)
            {
                Console.Write("Write first number: ");
                string Num1 = Console.ReadLine();

                Console.Write("Enter the symbol (+, -, *, /): ");
                string OP = Console.ReadLine();
                operation = Convert.ToChar(OP);

                if (checkConvertToDouble(Num1) && checkOperation(operation))
                {
                    num1 = Convert.ToDouble(Num1);
                    break;
                }
                else
                {
                    Console.WriteLine("Error. Try again: ");
                    Console.ReadLine();
                }
            }
        }

        static void checkNum2(out double num2)
        {
            while (true)
            {
                Console.Write("Write second number: ");
                string Num2 = Console.ReadLine();

                bool ConvertToDouble = checkConvertToDouble(Num2);
                if (!ConvertToDouble)
                {
                    Console.WriteLine("Error. Try again: ");
                    Console.ReadLine();
                    continue;
                }

                num2 = Convert.ToDouble(Num2);

                if (num2 == 0)
                {
                    Console.WriteLine("Can't divide by zero");
                }
                else
                {
                    break;
                }
            }
        }

        static double switchOperation(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }
}