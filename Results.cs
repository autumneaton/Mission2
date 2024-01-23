using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Results
    {
        // random number generator
        private Random random;

        public Results()
        {
            random = new Random();
        }

        // Method simulating the the roll of the dice
        public int[] RollDice(int numRolls)
        {
            int[] results = new int[13];

            // For loop for the number of rolls
            for (int i = 0; i < numRolls; i++)
            {
                // Generate two random numbers between 1 and 6
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                int sum = die1 + die2;

                // Increment the outcome array
                results[sum]++;
            }

            // Return the outcome array
            return results;
        }
    }
}
