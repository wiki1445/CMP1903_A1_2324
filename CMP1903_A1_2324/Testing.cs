//Review Changes
//Testing
using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Class for testing the game functionality.
    /// </summary>
    internal class Testing
    {
        /// <summary>
        /// Tests the game by rolling the dice and asserting their values.
        /// </summary>
        public static void TestGame()
        {
            //creates a game object in refrence to the class game
            Game game = new Game();
            //using game object it calles the rollalldice method
            game.RollAllDice();

            // Exception handling to ensure that Die actually gets a value and is not null.
            if (game.Die1 == null || game.Die2 == null || game.Die3 == null)
            {
                throw new ArgumentNullException("One or more dice objects are null.");
            }

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
