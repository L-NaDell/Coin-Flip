using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess which will have more: heads or tails?");
            
            string headsOrTailsGuess = Console.ReadLine();

            if (headsOrTailsGuess.ToLower() == "heads" || headsOrTailsGuess.ToLower() == "tails")
            {
                Console.WriteLine("How many times shall we flip a coin?");

                string numberOfFlips = Console.ReadLine();
                int parsedFlips = int.Parse(numberOfFlips);

                Random flipGen = new Random();
                int flipNum;
                int heads = 0;
                int tails = 0;

                for (int i = 0; i < parsedFlips; i++)
                {
                    flipNum = flipGen.Next(1, 3);
                    if (flipNum == 1)
                    {
                        Console.WriteLine("heads");
                        heads++;
                    }
                    else
                    {
                        Console.WriteLine("tails");
                        tails++;
                    }
                }
                double correctCount = 0;

                if (headsOrTailsGuess.ToLower() == "heads")
                {
                    correctCount = heads;
                }
                else
                {
                    correctCount = tails;
                }

                Console.WriteLine("Your guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s).");

                Console.WriteLine("That's " + ((correctCount/parsedFlips) *100) + "%.");
            }
            else
            {
                Console.WriteLine(headsOrTailsGuess + " is not an option.");
            }
        }
    }
}
