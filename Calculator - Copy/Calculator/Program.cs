using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string operation;

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Desired operation? Add, Subtract, Multiply, or Divide: ");
            operation = Console.ReadLine();
            if (operation == "Add")
            {
                AddNumbers(num1, num2);
            }
            else if (operation == "Subtract")
            {
                SubtractNumbers(num1, num2);
            }
            else if(operation == "Multiply")
            {
                MultiplyNumbers(num1, num2);
            }
            else if(operation == "Divide")
            {
                DivideNumbers(num1, num2);
            }
            else
            {
                Console.WriteLine("Error detected. Please run program again.");
            }
        }
        static int AddNumbers(int num1, int num2)
        {
            int Result = num1 + num2;
            Console.WriteLine(Result);
            return Result;
        }
        static int SubtractNumbers(int num1, int num2)
        {
            int Result = num1 - num2;
            Console.WriteLine(Result);
            return Result;
        }
        static int MultiplyNumbers(int num1, int num2)
        {
            int Result = num1 * num2;
            Console.WriteLine(Result);
            return Result;
        }
        static int DivideNumbers(int num1, int num2)
        {
            int Result = num1 / num2;
            Console.WriteLine(Result);
            return Result;
        }
    }
}
