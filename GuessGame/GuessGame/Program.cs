using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //general variables
                        
            string secretWord = "Elephant";

            string guessword = "";

            byte guessCount = 0;

            byte guessLimit = 3;

            bool outOfGuesses = false;

            static string GiveTips(int num)
            {
                string[] tips =
                    {
                        "it's the largest existing land animal",
                        "its trunk is a fusion of the nose and upper lip",
                        "it's name starts whit the letter E"
                    };
                return tips[num];
            }

            while(guessword != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.WriteLine("Guess what I'm thinking");
                    Console.WriteLine("here's a tip: " + GiveTips(guessCount));
                    Console.WriteLine("Chance " + (guessCount + 1) + " of " + guessLimit);
                    Console.WriteLine("Enter guess: ");
                    guessword = Console.ReadLine();
                    ++guessCount;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("You win");
            }
            




            //Console.WriteLine("Hello World!");
        }
    }
}
