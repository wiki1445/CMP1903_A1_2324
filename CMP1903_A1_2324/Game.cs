﻿//Game
using System;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Represents a game with three dice.
    /// </summary>
    internal class Game
    {
        //creates variables named die(1,2,3) in refrence to the die class
        private Die die1;
        private Die die2;
        private Die die3;

        /// <summary>
        /// Sets up a new instance of the Game class with three dice.
        /// </summary>
        //user defined method that performes the entire game
        public Game()
        {
            //initializes each die variable with the die class
            die1 = new Die();
            die2 = new Die();
            die3 = new Die();
        }

        /// <summary>
        /// Gets the first die object.
        /// </summary>
        //defines class properties
        public Die Die1 => die1;
        /// <summary>
        /// Gets the second die object.
        /// </summary>
        public Die Die2 => die2;
        /// <summary>
        /// Gets the third die object.
        /// </summary>
        public Die Die3 => die3;

        /// <summary>
        /// Rolls all three dice, prints their values, and calculates their sum.
        /// </summary>
        //user defined method that is responsible to print all die data and call dice function to recieve said data
        public void RollAllDice()
        {
            //print statement to print that the game is starting
            Console.WriteLine("Starting Game:");

            //calls the roll method in the dice class and prints its output
            int rollResult1 = die1.Roll();
            Console.WriteLine($"Die 1 roll: {rollResult1}");
            int rollResult2 = die2.Roll();
            Console.WriteLine($"Die 2 roll: {rollResult2}");
            int rollResult3 = die3.Roll();
            Console.WriteLine($"Die 3 roll: {rollResult3}");

            //gets the sum of all three die and prints
            int sum = rollResult1 + rollResult2 + rollResult3;
            Console.WriteLine($"Total sum of three dice rolls: {sum}");
        }
    }
}


