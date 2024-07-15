using System;

namespace Program
{
    class HangmanGame
    {
        static void Main(string[] args)
        {
            bool Replay = true;

            while (Replay)
            {
                // initialization variables

                Console.WriteLine("Enter the word to guess");
                string WordToFind = Console.ReadLine().ToLower();
                Console.Clear(); // Clear the Console to make sense of the game

                char[] CurrentWord = new char[WordToFind.Length]; // This variable will maintain the player's advance
                for (int i = 0; i < WordToFind.Length; i++)
                {
                    CurrentWord[i] = '_';
                }

                int attempt = 10; // number of tries remaining
                bool WordFound = false;
                string UserTest;

                


                while (!WordFound && attempt != 0) // main loop
                { 
                    Console.WriteLine(CurrentWord);
                    Console.WriteLine("Player, enter a letter or word");
                    UserTest = Console.ReadLine().ToLower();

                    if (UserTest.Length >= 1) 
                    { 
                        if (UserTest == WordToFind)
                        {
                            WordFound = true;
                        }
                        else
                        {
                            Console.WriteLine("You're Wrong! \n Try again...");
                            attempt--;
                        }
                    }


                    else if (UserTest.Length == 1)
                    {
                        char letter;
                        bool FindLetter = false;
                        letter = Console.ReadLine()[0];
                        for (int i = 0; i < WordToFind.Length; i++)
                        {
                            if (WordToFind[i] == letter)
                            {
                                CurrentWord[i] = letter;

                                FindLetter = true;
                                Console.WriteLine(CurrentWord);
                            }
                        }


                        if (FindLetter)
                        {
                            Console.WriteLine($"Congratulation ! You find the letter {letter}!");
                        }
                        else
                        {
                            Console.WriteLine($"Miss, the letter {letter} isn't in the word");
                            attempt--;
                        }
                    }


                    else // when no key is entered
                    {
                        Console.WriteLine("Please, press a letter on your keyboard");
                    }

                    //Console.Clear(); // Clear a Console every loop for a better visual (and little more difficult)
                }




                if (WordFound || new string(CurrentWord) == WordToFind)
                {
                Console.WriteLine("Youpiiiiiiii");
                }

                Console.WriteLine($"The Word to guess was '{WordToFind}'.");
            }

        }
    }
}