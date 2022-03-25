using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;


namespace TicTacToe_Test
{
    public class UnitTest1
    {
        [Fact] 
        public void CanFindWinner()           //Given a game board, Test for winners
        {
            Game game = new Game(new Player(), new Player());
            game.Board.GameBoard = new string[,]
            {
                {"O", "X", "3" },
                {"4", "O", "X" },
                {"7", "X", "O" },
            };
            Assert.True(game.CheckForWinner(game.Board));
        }
        [Fact]
        public void CanFindNoWinner()           //Given a game board, Test for NO winners
        {
            Game game = new Game(new Player(), new Player());
            game.Board.GameBoard = new string[,]
            {
                {"X", "X", "O"},
                {"O", "O", "X"},
                {"X", "O", "X"},
            };
            Assert.False(game.CheckForWinner(game.Board));
        }
        [Fact]
        public void CanSwitchPlayers()             //Test that there is a switch in players between turns
        {
            Player one = new Player() { IsTurn = true };
            Player two = new Player();
            Game game = new Game(one, two);
            game.SwitchPlayer();
            Assert.False(one.IsTurn);
        }
        [Fact]
        public void CheckForCorrectCoordinates()          
        //Confirm that the position the player inputs correlates to the CORRECT index of the array
        {
            Position testPosition = Player.PositionForNumber(2);
            int[] expected = { 0, 1 };
            int[] actual = new int[2];
            actual[0] = testPosition.Row;
            actual[1] = testPosition.Column;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckForIncorrectCoordinates()
        //Confirm that the position the player inputs correlates to the INCORRECT index of the array
        {
            Position testPosition = Player.PositionForNumber(10);
            Assert.Null(testPosition);
        }

        [Fact]
        public void NextPlayerWorks()            //One other “unique” test of your own
        {
            Player one = new Player() { Name = "Ola" };
            Player two = new Player() { Name = "Abeer", IsTurn = true };
            Game game = new Game(one, two);
            Player result = game.NextPlayer();
            Assert.Equal(two.Name, result.Name);
        }
    }
}
