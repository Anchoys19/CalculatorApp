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

                if (num2 == 0 && operation == '/')
                {
                    Console.WriteLine("Can't divide by zero");
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
                    operation = Convert.ToChar(OP);
                    break;
                }
                else
                {
                    Console.WriteLine("Error. Try again: ");
                    Console.ReadLine();
                }
            }
        }
    }
}