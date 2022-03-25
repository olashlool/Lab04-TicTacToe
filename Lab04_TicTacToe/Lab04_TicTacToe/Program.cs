using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

            Console.Write("Player 1: Enter Your Name: ");
            string playerOneName = Console.ReadLine();
            Player p1 = new Player
            {
                Name = playerOneName,
                Marker = "X",
                IsTurn = true
            };

            Console.Write("Player 2: Enter Your Name: ");
            string playerTwoName = Console.ReadLine();          
            Player p2 = new Player
            {
                Name = playerTwoName,
                Marker = "O",
                IsTurn = false
            };

            // Create the Game 
            Game newGame = new Game(p1, p2);

            // Play the Game 
            Player winner = newGame.Play();

            // Output the winner 
            if (winner == null)
                Console.WriteLine("Nobody winner.");
            else
                Console.WriteLine($"Congratulations, {winner.Name} is the WINNER.");
        }


    }
}
