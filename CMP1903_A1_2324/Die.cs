//Die
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// A six-sided die.
    /// </summary>
    public class Die
    {
        //Intializes a random number generator
        private static Random random = new Random();

        /// <summary>
        /// Rolls the die and returns the result.
        /// </summary>
        /// <returns>The value rolled on the die.</returns>
        //User defined method that performs "roll" task
        public int Roll()
        {
            //Gets a random int number from 1-6 and returns
            CurrentValue = random.Next(1, 7);
            return CurrentValue;
        }

        /// <summary>
        /// Gets or sets the current value of the die.
        /// </summary>
        //Defines a public integer named CurrentValue
        public int CurrentValue { get; private set; } = 1;
    }
}
