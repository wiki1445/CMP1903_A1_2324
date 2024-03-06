//Testing
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public static void TestGame()
        {
            //creates a game object in refrence to the class game
            Game game = new Game();
            //using game object it calles the rollalldice method
            game.RollAllDice();

            //tests and asserts the games output values to make sure they are within the criteria
            Debug.Assert(game.Die1.CurrentValue >= 1 && game.Die1.CurrentValue <= 6,
                $"Die 1 roll is out of range (1-6). Actual value: {game.Die1.CurrentValue}");

            Debug.Assert(game.Die2.CurrentValue >= 1 && game.Die2.CurrentValue <= 6,
                $"Die 2 roll is out of range (1-6). Actual value: {game.Die2.CurrentValue}");

            Debug.Assert(game.Die3.CurrentValue >= 1 && game.Die3.CurrentValue <= 6,
                $"Die 3 roll is out of range (1-6). Actual value: {game.Die3.CurrentValue}");
        }
    }
}