//Die
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {
        //intializes an random number generator
        private static Random random = new Random();

        //user defined method that performs "roll" task
        public int Roll()
        {
            //gets a random int number from 1-6 and returns
            CurrentValue = random.Next(1, 7);
            return CurrentValue;
        }

        //Defines a public integer named CurrentValue
        public int CurrentValue { get; private set; } = 1;
    }
}
