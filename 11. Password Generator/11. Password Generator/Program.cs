using System;

namespace Program
{

    class Password
    {
        // Create an instance of class random
        private static Random rand = new Random();

        public static void Main(string[] args)
        {                    
            List<string> strongpassword = CreatePassword(6, 5, 5); ; // Define the number of characters as a parameter

            Console.WriteLine("Your new password is:");        
            foreach (string character in strongpassword)
            {
                Console.Write(character);
            }
        }


        public static List<string> CreatePassword( int letter, int number, int special)
            // Create and strong password with several steps (to easily change settings)
        {
            List<string> password = new List<string>();

            RandomLetter(password,letter);
            RandomNumber(password, number);
            RandomSpecialCharacter(password, number);
            return MixPassword(password);
        }



        public static void RandomLetter(List<string> listCharacters, int nbr)
            // Add random letter to the list (uppercase and lowercase)
        {
            string letterlist = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < nbr; i++)
            {
                char randomletter = letterlist[rand.Next(0, 52)];
                listCharacters.Add(randomletter.ToString());
            }
        }

        public static void RandomSpecialCharacter(List<string> listCharacters, int nbr)
            // Add Random Specials characters to the list
        {
            string speciallist = "&(-_)*/:.~#'@{-}[_]";

            for (int i = 0; i < nbr; i++)
            {
                char randomcharacter = speciallist[rand.Next(0, 18)];
                listCharacters.Add(randomcharacter.ToString());
            }
        }


        public static void RandomNumber(List<string> listCharacters, int nbr)
            // Add random number to the list
        {
            for (int i = 0; i < nbr; i++)
            {
                int randomnumber = rand.Next(0, 10);
                listCharacters.Add(randomnumber.ToString());
            }
        }


        private static List<string> MixPassword(List<string> password)
        {
            return password.OrderBy(x => rand.Next()).ToList();             
        }


    }
}








