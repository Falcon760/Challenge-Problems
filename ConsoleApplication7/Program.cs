using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random number guesser plus guesses tracker

            int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] list2 = new int[] { 1, 2, 3, 4, 5, 6 };
            Random randomNumber = new Random();
            int num = randomNumber.Next(1, 10);
            Console.WriteLine("We have picked a random number! What is your guess?");
            int guess = int.Parse(Console.ReadLine());

            for (int i = 1; i <= list2.Length; i++)
            {
                if (guess == num)
                {
                    Console.WriteLine("Correct");
                    Console.WriteLine("It took you {0} tries", i);
                    break;
                }
                else
                {
                    Console.WriteLine("Not correct!  Next guess? ");
                    if (guess > num)
                    {
                        Console.WriteLine("Guess number {0} was too high! Try again:", i);
                    }
                    else
                        Console.WriteLine("Guess number {0} was too low! Try again:", i);
                    int guess2 = int.Parse(Console.ReadLine());
                    guess = guess2;
                }
            }
            Console.ReadLine();




        }
    }
}
