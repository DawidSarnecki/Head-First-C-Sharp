using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame(ParseInputNumber());
        }

        static int ParseInputNumber()
        {
            int diceSize = 0;
            while (true)
            {
                Console.WriteLine("Give the number of your dice sides");
                try
                {
                    diceSize = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your dice has {0}", diceSize);
                    if (diceSize < 4)
                    {
                        Console.WriteLine("There are no dices less than 4 sides");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("You have provided incorrect data.  \n  Propably the given value is not a number ");
                }
            }
            return diceSize;

        }


        static void StartGame(int diceSize)
        {
            Random yourRandomNmber = new Random();
            string userInput = "";
            while (!userInput.Equals("EXIT"))
            {
                RunAnimation();
                Console.WriteLine("\n \t Congratulations! You random number is: {0}. \n For Exit type EXIT nad press Enter. \n", yourRandomNmber.Next(1, diceSize));
               userInput = Console.ReadLine();
            }
        }

        static void RunAnimation()
        {
            Console.Write("Randoming... ");
            using (var progress = new ProgressBar())
            {
                for (int i = 0; i <= 100; i++)
                {
                    progress.Report((double)i / 100);
                    Thread.Sleep(10);
                }
            }
            Console.WriteLine("Done.");

        }

        static void RunAnimationUsingStopWatch()
        {
            Console.Clear();
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            TimeSpan timeOut = TimeSpan.FromSeconds(1);
            while (stopWatch.Elapsed < timeOut)
            {
                Console.Write(" # ");
                //drawTextProgressBar(stopWatch.Elapsed.Milliseconds, timeOut.Milliseconds);
            }
            Console.Clear();
        }
           

        // draw progress bar method from https://stackoverflow.com/questions/24918768/progress-bar-in-console-application
        private static void drawTextProgressBar(int progress, int total)
        {
            //draw empty progress bar
            Console.CursorLeft = 0;
            Console.Write("["); //start
            Console.CursorLeft = 100;
            Console.Write("]"); //end
            Console.CursorLeft = 1;
            float onechunk = 1000f / (total);

            //draw filled part
            int position = 1;
            for (int i = 0; i < onechunk * progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw unfilled part
            for (int i = position; i <= 100; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw totals
            Console.CursorLeft = 105;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progress.ToString() + " of " + total.ToString() + "    "); //blanks at the end remove any excess
        }
    }   
}

