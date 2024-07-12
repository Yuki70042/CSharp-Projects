using System;

namespace Program
{

    class Calculator
    {

        static void Main(string[] args)
        {

            // Initialization
            bool isCalculating = true;
            double result = default;

            double number1 = default;
            double number2 = default;
            char operation = default;


            while (isCalculating) // main loop 
            {

                // recovery the first number and check the validity

                while (true)
                {
                    Console.WriteLine(" Enter your first number;");
                    string input1 = Console.ReadLine();

                    if (double.TryParse(input1, out number1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                // recovery the operator 
                Console.WriteLine("Enter your operator;");
                operation = Console.ReadLine()[0];



                // recovery the second number
                while (true)
                {
                    Console.WriteLine(" Enter your second number;");
                    string input2 = Console.ReadLine();

                    if (double.TryParse(input2, out number2))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }



                // treatment of the operation
                switch (operation) 
                {
                    case '+':
                        result = Add(number1, number2);
                        break;

                    case '-':
                        result = Substract(number1, number2);
                        break;

                    case '/': 
                        if (number2 == 0) // case where the division is by 0
                        {
                            Console.WriteLine("Error: Divide by zero!");
                            continue;
                        }
                        else
                        {
                            result = Divide(number1, number2);
                            break;
                        }
                        

                    case '*':
                        result = Multiply(number1, number2);
                        break;

                    default:
                        Console.WriteLine("Operation invalide");
                        continue;

                }


                // Check if the user wants continue to use the calculator
                Console.WriteLine($"{number1} {operation} {number2} = {result}"); 
                Console.WriteLine("Would you like to continue? y/n");

                if (Console.ReadLine().ToLower() != "y")
                {
                    isCalculating = false;
                    Console.WriteLine("Thank you to use this calculator !");
                }

            }
        
        }

        static double Add(double a, double b )  // make an addition
        {
            return a + b;
        }

        static double Substract(double a, double b) // make a subtraction
        {
            return a - b;
        }

        static double Divide(double a, double b) // make a division
        {    
                return a / b;
        }

        static double Multiply(double a, double b) // make a multiplication
        {
            return a * b;
        }
    }
}