/* 
Kevin Paul

Write a program that simulates the rolling of two 6-sided dice. Use an Array to keep track of the
number of times that each total number is thrown. In other words, keep track of how many times
the combination of the two simulated dice is 2, how many times the combination is 3, and so on,
all the way up through 12.

Allow the user to choose how many times the “dice” will be thrown. Then, once the dice have
been thrown the specified number of times, print a histogram (using the* character) that shows
the total percentage each number was rolled. Each * will represent 1% of the total rolls.
*/

using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            int totalRolls = Convert.ToInt32(Console.ReadLine());

            Dice dice = new Dice();

            // Simulates rolling 2 dice for specified amount
            dice.RollDice(totalRolls);

            dice.DisplayStats();

            Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
