using System;

namespace Models
{
    public class Guess
    {
        public int GuessedNumber { get; set; }
        public DateTime GuessTime { get; set; }

        public Guess(int guessedNumber, DateTime guessTime)
        {
            GuessedNumber = guessedNumber;
            GuessTime = guessTime;
        }
    }
}
