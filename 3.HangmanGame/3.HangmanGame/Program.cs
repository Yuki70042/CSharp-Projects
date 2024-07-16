using System;
using System.Threading;

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

                Console.WriteLine("Let's Start ! \nEnter the word to guess");
                string WordToFind = Console.ReadLine().ToLower();
                Console.WriteLine($"Word '{WordToFind}' validate.\n Warning. The console will be clear");
                Thread.Sleep(3000);
                Console.Clear(); // Clear the Console to make sense of the game


                char[] CurrentWord = new char[WordToFind.Length]; // This variable will maintain the player's advance
                for (int i = 0; i < WordToFind.Length; i++)
                {
                    CurrentWord[i] = '_';
                }

                int attempt = 10; // number of tries remaining
                bool WordFound = false;
                string UserInput;


                while (!WordFound && attempt != 0)
                {
                    Console.WriteLine(CurrentWord);
                    Console.WriteLine("Joueur, entrez une lettre ou tapez le mot complet pour deviner :");

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
                            Console.WriteLine($"Too bad for you, the letter '{letter}' isn't in the word to guess");
                            attempt--;
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
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valide letter");
                    }

                    // Vérifie si le mot a été entièrement trouvé
                    if (new string(CurrentWord) == WordToFind)
                    {
                        WordFound = true;
                    }
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