using System;
using Data;
using Models;

namespace Controllers
{
    public class GameController
    {
        private int hiddenNumber;
        private Random random;

        public GameController()
        {
            random = new Random();
            hiddenNumber = random.Next(1, 101); 
        }

        public void HandleGuess(int guess, GuessHistory guessHistory)
        {
            DateTime guessTime = DateTime.Now;

            if (guess < hiddenNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number!");
                guessHistory.AddGuess(guess, guessTime); 
                hiddenNumber = random.Next(1, 101); 
            }

          
            guessHistory.AddGuess(guess, guessTime);
        }
    }
}
