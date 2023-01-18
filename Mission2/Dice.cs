// Kevin Paul

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Dice
    {
        private int[] rollValues = new int[11];

        //Rolls two dice
        private int Roll()
        {
            Random rnd = new Random();

            int roll1 = rnd.Next(1,7);
            int roll2 = rnd.Next(1,7);

            return (roll1 + roll2);
        }

        //Rolls dice for specified amount and stores values in array
        public void RollDice(int rollAmount)
        {
            for (int i = 0; i < rollAmount; i++)
            {
                int rollValue = Roll();

                if (rollValue == 2)
                {
                    rollValues[0] += 1;
                }
                else if (rollValue == 3)
                {
                    rollValues[1] += 1;
                }
                else if (rollValue == 4)
                {
                    rollValues[2] += 1;
                }
                else if (rollValue == 5)
                {
                    rollValues[3] += 1;
                }
                else if (rollValue == 6)
                {
                    rollValues[4] += 1;
                }
                else if (rollValue == 7)
                {
                    rollValues[5] += 1;
                }
                else if (rollValue == 8)
                {
                    rollValues[6] += 1;
                }
                else if (rollValue == 9)
                {
                    rollValues[7] += 1;
                }
                else if (rollValue == 10)
                {
                    rollValues[8] += 1;
                }
                else if (rollValue == 11)
                {
                    rollValues[9] += 1;
                }
                else
                {
                    rollValues[10] += 1;
                }
            }
        }

        //Displays all the stats
        public void DisplayStats()
        {
            int numRolls = rollValues.Sum();

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \" * \" represents 1 % of the total number of rolls.\nTotal number of rolls = " + numRolls + ".\n");
            for (int i = 0; i < 11; i++)
            {
                int asteriskAmount = (int)((rollValues[i] / (decimal)numRolls) * 100);

                Console.Write("\n" + (i + 2) + ": ");
                
                for (int j = 0; j < asteriskAmount; j++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
