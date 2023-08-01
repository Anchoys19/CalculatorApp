using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char operation;
            double num1, num2;

            while (true)
            {
                Console.Write("Write first number: ");
                string Num1 = Console.ReadLine();
                bool ConvertToDouble = CheckConvertToDouble(Num1);
                if (ConvertToDouble)
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

            while (true)
            {
                Console.Write("Enter the symbol (+, -, *, /): ");
                string OP = Console.ReadLine();
                operation = Convert.ToChar(OP);
                if (CheckOperation(operation))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.ReadLine();
                }
            }

            while (true)
            {
                Console.Write("Write second number: ");
                string Num2 = Console.ReadLine();

                bool ConvertToDouble = CheckConvertToDouble(Num2);
                if (!ConvertToDouble)
                {
                    Console.WriteLine("Error. Try again: ");
                    Console.ReadLine();
                    continue;
                }

                num2 = Convert.ToDouble(Num2);

                if (num2 == 0 && operation == '/')
                {
                    Console.Write("Can't divide by zero");
                }
                else
                {
                    break;
                }
            }

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

        static bool CheckConvertToDouble(string arg)
        {
            try
            {
                double num1 = Convert.ToDouble(arg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static bool CheckOperation(char symb)
        {
            if (symb == '+' || symb == '-' || symb == '*' || symb == '/')
            {
                return true;
            }

            return false;
        }
    }
}