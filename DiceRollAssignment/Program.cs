//Sam Reyes | Section 03
//Program that simulates throwing two, six-sided dice
//and returns a histogram with the percentage of each total number rolled

using System;

namespace DiceRollAssignment
{
    class Program
    {
        static void RollDice()
        {
            // Declare Variables
            Random r = new Random();
            int[] diceNums = new int[11];
            double rollPct;
            string stars = "";

            // Introduction
            Console.WriteLine("Welcome to the dice rolling simulator!" + System.Environment.NewLine);

            // Recieve input (desired dice rolls)
            Console.WriteLine("Enter number of rolls desired: ");
            int rollNumber = Int32.Parse(Console.ReadLine());

            // For each roll
            for (int i = 0; i < rollNumber; i++)
            {
                // Generate random number for each die
                int diceOne = r.Next(0, 6);
                int diceTwo = r.Next(0, 6);

                // Add the two numbers
                int diceTotal = diceOne + diceTwo;

                // Increase array by one at the corresponding position
                diceNums[diceTotal] = diceNums[diceTotal] + 1;
            }

            // Generate Results
            Console.WriteLine(System.Environment.NewLine + "RESULTS:" + System.Environment.NewLine);
            Console.WriteLine("Each * represents 1% of the total number of rolls" + System.Environment.NewLine);
            Console.WriteLine("Total number of rolls = " + rollNumber.ToString() + System.Environment.NewLine);


            // For each position in the array
            for (int i = 0; i < 11; i++)
            {
                stars = "";

                // Divide the number of occurances by the total rolls to find the percent 
                rollPct = ((double)diceNums[i] / (double)rollNumber)*100;
                Math.Round(rollPct, 0);

                // In each array position, add a star for every value
                for (int inner = 0; inner < rollPct; inner++)
                {
                    stars += "*";

                }
                
                // Print array value and stars
                stars = (i + 2).ToString() + ": " + stars;
                Console.WriteLine(stars);

            }

            //Final result message
            Console.WriteLine(System.Environment.NewLine + "Thanks for using the dice rolling simulator!");
        }
        static void Main(string[] args)
        {
            //Execute Program
            RollDice();
        }

    }
}
