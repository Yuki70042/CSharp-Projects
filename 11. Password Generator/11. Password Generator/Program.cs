using System;

namespace Program
{

    class Calculator
    {
        
        public static void Main(string[] args)
        {
            List<string> password = new List<string>();

            Console.WriteLine($"Your new password is: '{password}'");
            CreatePassword(password, 5,5,5);    
            foreach (string character in password)
            {
                Console.Write(character);
            }
        }




        public static void CreatePassword(List<string>password, int letter, int number, int special)
        {
            RandomLetter(password,letter);
            RandomNumber(password, number);
            RandomSpecialCharacter(password, number);
        }



        public static void RandomLetter(List<string> listCharacters, int nbr)
            // Add random letter to the list (uppercase and lowercase)
        {
            Random rand = new Random();
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
            Random rand = new Random();
            string speciallist = "&(-_)*/:,.~#'@{}[]";

            for (int i = 0; i < nbr; i++)
            {
                char randomcharacter = speciallist[rand.Next(0, 18)];
                listCharacters.Add(randomcharacter.ToString());
            }
        }


        public static void RandomNumber(List<string> listCharacters, int nbr)
            // Add random number to the list
        {
            Random rand = new Random();

            for (int i = 0; i < nbr; i++)
            {
                int randomnumber = rand.Next(0, 10);
                listCharacters.Add(randomnumber.ToString());
            }
        }


        private static void MixPassword(List<string> password)
        {

        }


    }
}








