using System;
using System.Threading;

namespace Program
{
    class HangmanGame
    {
        static void Main(string[] args)
        {
            bool Replay = true;
            
            /*
            // ---  Introduction and Rules Part
            Console.WriteLine("Welcome in my new small game Players !");
            Thread.Sleep(1500);
            Console.WriteLine("You have just entered in the fabulous game of hangman.");
            Console.WriteLine("Let's see the rules...");
            Thread.Sleep(2000);
            Console.WriteLine("\nThe first player begins by entering a word!");
            Thread.Sleep(2000);
            Console.WriteLine("The second one must guess this word.");
            Thread.Sleep(1500);
            Console.WriteLine("For that, each round he can give a letter.\nIf the letter is in the word, it appears in the right place.");
            Thread.Sleep(2500);
            Console.WriteLine("But if the letter isn't, we draw part of the hanged man");
            Thread.Sleep(1500);
            Console.WriteLine("The game is lost if the hanged man is drawn in full!\n");
            Thread.Sleep(1000);
            // -------------------------------------------------------------------------
            */

            while (Replay)
            {
                // initialization variables

                Console.WriteLine("Now, Let's Start ! \nPlease Player 1, Enter the word to guess :");
                string WordToFind = Console.ReadLine().ToLower();
                Console.WriteLine($"Word '{WordToFind}' validate!\nWarning,\nThe console will be clear shortly...");
                
                Thread.Sleep(3000);
                Console.Clear(); // Clear the Console to make sense of the game

                char[] CurrentWord = new char[WordToFind.Length]; // This variable will maintain the player's advance
                for (int i = 0; i < WordToFind.Length; i++)       // It takes the same length as WordToFind variable
                {
                    CurrentWord[i] = '_';                         // We "hide" the characters
                    
                }

                int attempt = 10; // number of tries remaining
                bool WordFound = false;
                string UserInput;


                //  ----------------        A Cool Animation 
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Loading.");
                    Thread.Sleep(0400);
                    Console.Clear();
                    Console.WriteLine("Loading..");
                    Thread.Sleep(0400);
                    Console.Clear();
                    Console.WriteLine("Loading...");
                    Thread.Sleep(0400);
                    Console.Clear();
                } // -------------------------------



                while (!WordFound && attempt != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(CurrentWord);
                    Console.WriteLine("\nPlayer 2 it's your turn,\nEnter a letter or the word you think it is:");
                    UserInput = Console.ReadLine().ToLower(); // change user input in lowercase


                    if (UserInput.Length == 1 && char.IsLetter(UserInput[0])) // User input only one character, a letter
                    {

                        char letter = UserInput[0];
                        bool letterFound = false;

                        // Check if the letter is in the word
                        for (int i = 0; i < WordToFind.Length; i++)
                        {
                            if (WordToFind[i] == letter)
                            {
                                CurrentWord[i] = letter;
                                letterFound = true;
                            }
                        }

                        if (!letterFound)
                        {
                            Console.WriteLine($"Miss, the letter '{letter}' isn't in the word to guess");
                            Console.WriteLine("The second Player will add a part of the hangman...");
                            attempt--;
                            string hangmanDisplay = Print_Hangman(attempt);
                            Console.WriteLine(hangmanDisplay);
                        }
                        else
                        {
                            Console.WriteLine("Yeaah, you found a right letter !");
                        }
                    }


                    else if (UserInput.Length > 1) // If the user input a word
                    {

                        if (UserInput == WordToFind)
                        {
                            WordFound = true;
                        }
                        else
                        {
                            Console.WriteLine("Wrong ! \n Try again...");
                            attempt--;
                            string hangmanDisplay = Print_Hangman(attempt);
                            Console.WriteLine(hangmanDisplay);
                        }
                    }


                    else
                    {
                        Console.WriteLine("Please enter a valide letter");
                    }


                    // Check if the word was found
                    if (new string(CurrentWord) == WordToFind)
                    {
                        WordFound = true;
                    }


                    Thread.Sleep(1000);

                } // -----   End of the main loop




                Thread.Sleep(1000);
                if (WordFound || new string(CurrentWord) == WordToFind)
                {
                Console.WriteLine("Congratulation you found the Secret Word !");
                }
                else
                {
                    Console.WriteLine("Too bad... You didn't found the Secret Word");
                }

                Thread.Sleep(1000);
                Console.WriteLine($"The Word to guess was '{WordToFind}'.");



                // --- Does the player want to restart the game
                bool validInput = false;

                while (!validInput)
                {
                    Console.WriteLine("Do you want to restart the game? y/n");
                    string input = Console.ReadLine();
                    char answer = !string.IsNullOrEmpty(input) ? input[0] : 'n';

                    if (answer == 'n' || answer == 'N')
                    {
                        Console.WriteLine("It was really cool!\nSee you soon!");
                        Replay = false;
                        validInput = true;
                    }
                    else if (answer == 'y' || answer == 'Y')
                    {
                        Console.WriteLine("Perfect,\n Let's go for a new party!");
                        Thread.Sleep(1500);
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    }
                }
                // -------------------------------------
            }

        }

        public static string Print_Hangman(int lvl) // Method for display the progress of hangman
        {
            switch (lvl)
            {
                case 9:
                    return "+";
                case 8:
                    return "+\r\n    |";
                case 7:
                    return "    +---+\r\n    |";
                case 6:
                    return "    +---+\r\n    |   |";
                case 5:
                    return "    +---+\r\n    |   |\r\n    O   |\r\n        ";
                case 4:
                    return "    +---+\r\n    |   |\r\n    O   |\r\n    |   |";
                case 3:
                    return "    +---+\r\n    |   |\r\n    O   |\r\n   /|   |\r\n";
                case 2:
                    return "    +---+\r\n    |   |\r\n    O   |\r\n   /|\\  |";
                case 1:
                    return "    +---+\r\n    |   |\r\n    O   |\r\n   /|\\  |\r\n   /\r\n";
                default:
                    return "    +---+\r\n    |   |\r\n    O   |\r\n   /|\\  |\r\n   / \\  |";
            }


        }
    }
}