using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random number guesser in limited number of tries


            int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] list2 = new int[] { 1, 2, 3, 4, 5, 6 };
            Random randomNumber = new Random();
            int num = randomNumber.Next(1, 10);
            Console.WriteLine("We have picked a random number! What is your guess?");
            int guess = int.Parse(Console.ReadLine());

            for (int i = 6; i > 0; i--)
            {
                if (guess == num)
                {
                    Console.WriteLine("Correct");
                    break;
                }
                else
                {
                    Console.WriteLine("Not correct!  Next guess? ");
                    if (guess > num)
                    {
                        Console.WriteLine("Too high! You have {0} guesses left! Try again:", i);
                    }
                    else
                        Console.WriteLine("Too low! You have {0} guesses left! Try again:", i);
                    int guess2 = int.Parse(Console.ReadLine());
                    guess = guess2;
                }
               
            }
            Console.ReadLine();
        }
    }
}
