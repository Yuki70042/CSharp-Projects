using System;
using System.ComponentModel.Design;

namespace Program
{
    class DiceGame
    { 
        static void Main(string[] args)
        {

            Random random = new Random();  // create an instance of the random class
            
            // initialization of variables
            int round = 0; 
            int number1 = 0;
            int number2 = 0;
            int scoreP1 = 0;
            int scoreP2 = 0;

            number1 = random.Next(1,7); // the second number is exclusive
            number2 = random.Next(1,7);

            Console.WriteLine(number1);
        }
    }

}