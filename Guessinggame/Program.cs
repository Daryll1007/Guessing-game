using System;
using Controllers;
using Data;
using Models;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GameController gameController = new GameController();
            GuessHistory guessHistory = new GuessHistory();

           
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("Guess the hidden number between 1 and 100.");

            bool gameOver = false;
            while (!gameOver)
            {
                
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                if (input != null && int.TryParse(input, out int guess))
                {
                    gameController.HandleGuess(guess, guessHistory);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }


                
            }
        }
    }
}
