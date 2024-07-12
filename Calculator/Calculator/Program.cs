using System;

namespace Program
{

    class Calculator
    {

        static void Main(string[] args)
        {
            bool isCalculating = true;
            double result = default;

            double number1 = default;
            double number2 = default;
            char operation = default;

            while (isCalculating)
            {
                Console.WriteLine(" Enter your first number;");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" Enter your operator;");
                operation = Console.ReadLine()[0];

                Console.WriteLine(" Enter your second number;");
                number2 = Convert.ToDouble(Console.ReadLine());

                

            
                switch (operation)
                {
                    case '+':
                        result = Add(number1, number2);
                        break;

                    case '-':
                        result = Substract(number1, number2);
                        break;

                    case '/':
                        result = Divide(number1, number2);
                        break;

                    case '*':
                        result = Multiply(number1, number2);
                        break;

                    default:
                        Console.WriteLine("Operation invalide");
                        continue;

                }

                Console.WriteLine($"{number1} {operation} {number2} = {result}");
                Console.WriteLine("Would you like to continue? y/n");

                if (Console.ReadLine().ToLower() != "y")
                {
                    isCalculating = false;
                    Console.WriteLine("Thank you to use this calculator !");
                }

            }
        
        }

        static double Add(double a, double b )
        {
            return a + b;
        }

        static double Substract(double a, double b)
        {
            return a - b;
        }

        static double Divide(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Error: Divide by zero!");
                return 0;
            }
            else
            {
                return a / b;
            }
            
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}