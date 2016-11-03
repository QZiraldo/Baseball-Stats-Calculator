using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Stats_Calculator     //Quirico Ziraldo 11/2/16
{
    class Program
    {
        static void Main(string[] args)
        {                                               //MAIN
            Console.WriteLine("Welcome to the Baseball Statistics Calculator!");
            // initial greeting 
            string run;
            do
            // while loop open
            {
                int numHitters = GetInput("Enter number of batters: ");     
                int atBats = GetInput("Enter number of times at bat: ");
                double battingAverage = 0;
                double sluggingPercentage = 0;
                int sumBases = 0;
                int sumHits = 0;


                double[,] allStats = new double[2, numHitters];                //create arrays
                int[] battingResults = new int[atBats];
                //for (int i = 1; i < numHitters; i++)
                //{
                //    allStats[, 1] = battingAverage;
                //    allStats[i,] = sluggingPercentage;
                //}








                Console.WriteLine("\n0= Out, 1= Single, 2= Double, 3= Triple, 4= Long Ball\n");

                int n = 0;
                do
                {
                    n++;
                    for (int i = 0; i < atBats; i++)                                // Input loop to colect results
                    {
                        Console.Write("result for at bat {0}: ", i + 1);
                        battingResults[i] = int.Parse(Console.ReadLine());
                    }
                } while (n < numHitters);

                
                

                for (int i = 0; i < battingResults.Length; i++)                 //taking values for hits and Total bases from input array
                {
                    sumBases += battingResults[i];
                    sumHits += battingResults[i] >= 1 ? 1 : 0;

                    //    (condition) ? firstValues : secondValues
                    //if (battingResults[i] >= 1)
                    //    sumHits++;
                }


                battingAverage =(double) sumHits / atBats;
                sluggingPercentage = (double) sumBases / atBats;

                battingAverage = Math.Round(battingAverage, 3);
                sluggingPercentage = Math.Round(sluggingPercentage, 3);


                Console.WriteLine("Batting Average: " + battingAverage);
                Console.WriteLine("Slugging Percentage: " + sluggingPercentage);

                Console.WriteLine("\nAnother Hitter? (y/n)\n");
                run = Console.ReadLine();
                // asks user to continue or exit
            }

            while (run == "y");
            // while loop close
        }                                                               //MAIN


        private static int GetInput(string P)                          //METHOD FOR INPUT
        {
            int input;
            Console.WriteLine(P);

            input = int.Parse(Console.ReadLine());
            return input;


        }
    }
}
