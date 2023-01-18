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
            Console.WriteLine("Welcome to the dice rolling simulator!" + System.Environment.NewLine);

            Console.WriteLine("Enter number of rolls desired: ");
            int inputNumber = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                int diceOne = r.Next(0, 6);
                int diceTwo = r.Next(0, 6);
                int diceTotal = diceOne + diceTwo;
                diceNums[diceTotal] = diceNums[diceTotal] + 1;
            }

            Console.WriteLine("RESULTS:" + System.Environment.NewLine);
            Console.WriteLine("Each * represents 1% of the total number of rolls" + System.Environment.NewLine);
            Console.WriteLine("Total number of rolls = " + inputNumber.ToString() + System.Environment.NewLine);

            for (int i = 0; i < 11; i++)
            {
                stars = "";
                rollPct = ((double)diceNums[i] / (double)inputNumber)*100;
                Math.Round(rollPct, 0);
                for (int inner = 0; inner < rollPct; inner++)
                {
                    stars += "*";

                }
                
                stars = (i + 2).ToString() + ": " + stars;

                Console.WriteLine(stars);

            }

            Console.WriteLine(System.Environment.NewLine + "Thanks for using the dice rolling simulator!");
        }
        //static void DisplayHist(int[] results)
        //{

        //}
        static void Main(string[] args)
        {
            RollDice();
        }

    }
}
