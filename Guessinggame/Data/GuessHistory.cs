using System;
using System.Collections.Generic;
using Models;

namespace Data
{
    public class GuessHistory
    {
        private List<Guess> guesses;

        public GuessHistory()
        {
            guesses = new List<Guess>();
        }

        public void AddGuess(int guess, DateTime guessTime)
        {
            guesses.Add(new Guess(guess, guessTime));
        }

        public void DisplayHistory()
        {
            
        }
    }
}
