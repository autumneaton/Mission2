using Mission2;
// This is so I don't need to write system in front
// using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // This is creating an instance of the Dice class
        Results r = new Results();

        // Ask for number of rolls
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        // Create rolls variable
        int numRolls = int.Parse(Console.ReadLine());

        // Simulate the dice rolls and get the results array
        int[] results = r.RollDice(numRolls);

        // Print the * results
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls);

        for (int i = 2; i <= 12; i++)
        {
            // Calculate the percentage of each result
            double percentage = (double)results[i] / numRolls * 100;

            // Round the percentage to the nearest integer
            int rounded = (int)Math.Round(percentage);

            // Print the result and the corresponding number of asterisks
            Console.Write($"{i}: ");
            for (int j = 0; j < rounded; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Thank the user and end the program
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}