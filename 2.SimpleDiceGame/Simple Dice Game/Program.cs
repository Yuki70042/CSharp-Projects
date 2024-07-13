using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Threading;

namespace Program
{
    class DiceGame
    {
        static void Main(string[] args)
        {

            Random random = new Random();  // create an instance of the random class to use it

            // initialization of variables
            int round = 0;
            int number1 = 0;
            int number2 = 0;
            int scoreP1 = 0;
            int scoreP2 = 0;


            Console.WriteLine(" Welcome PLayer !");
            Console.WriteLine(" Let's start to play a small Dice Game");
            Console.WriteLine(" It's very simple you will see, here are the rules:");
            Console.WriteLine(" You roll a die and so does the computer");
            Console.WriteLine(" The player with the highest score earns a point");
            Console.WriteLine(" There will be 5 rounds");
            Console.WriteLine(" Ready? Press a Key to begin !");
            Console.ReadKey(true); // Wait the Player press a Key


            Console.WriteLine(" Go !");
            Console.Beep();
            // 2 second pause before computer turn
            Thread.Sleep(2000); // (2 seconds)


            while (round < 3) // main loop
            {
                round++;
                Console.WriteLine($"\n Round : {round}");
                Console.WriteLine($"score Player: {scoreP1} / score computer: {scoreP2}");


                // Player's turn
                Console.WriteLine("\nPlayer 1, it's your turn! Press any key to roll the die...");
                Console.ReadKey(true); // Wait the Player press a Key
                number1 = random.Next(1, 7); // the second number is exclusive
                Console.WriteLine($"You got a {number1}!");

                // 2 second pause before computer turn
                Thread.Sleep(2000); // (2 seconds)

                // Computer's turn
                Console.WriteLine("It's the computer's turn...");
                // 2 second pause before computer turn
                Thread.Sleep(2000); // (2 seconds)
                number2 = random.Next(1, 7);
                Console.WriteLine($"It's a {number2}!");

                // 1 second pause before computer turn
                Thread.Sleep(1000); // (1 second)

                // Check the results
                if (number1 > number2) // if player win
                {
                    Console.WriteLine("Yeaah! Player you win a point!");
                    scoreP1++;
                }
                else if (number1 < number2) // if computer win
                {
                    Console.WriteLine("Oww... no luck, the computer won.");
                    scoreP2++;
                }
                else // equality
                {
                    Console.WriteLine("It's an equality");
                    Console.WriteLine("Let's start again");
                }
            }

            Console.WriteLine("The game is over!");
            Console.WriteLine("Let's see the result \n");

            // 4 second pause before computer turn
            Thread.Sleep(2000); // (4 seconds)

            if (scoreP1 > scoreP2)
            {
                Console.WriteLine("Congratulation Player you won this game ! You're a boss !");
            }
            else if (scoreP1 < scoreP2)
            {
                Console.WriteLine("Too bad... The computer won.");
            }
            else 
            { 
                Console.WriteLine(" It's an equality !"); 
            }

            Console.WriteLine("\n Thank you for playing !");
            Console.WriteLine($"score Player: {scoreP1} / score computer: {scoreP2}");

        }
    }

}