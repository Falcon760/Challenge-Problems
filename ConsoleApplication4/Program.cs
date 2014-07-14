using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {

        //Pick a random number and have a user guess it.
        //Tell the user if it is high or low.

        static void Main(string[] args)
        {
            int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Random randomNumber = new Random();
            int num = randomNumber.Next(1, 10);
            Console.WriteLine("We have picked a random number! What is your guess?");
            int guess = int.Parse(Console.ReadLine());

            for (int i = 0; i <= list.Length; i++)
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
                        Console.WriteLine("Too high btw!");
                    else
                        Console.WriteLine("Too low btw!");
                    int guess2 = int.Parse(Console.ReadLine());
                    guess = guess2;
                }
            }
            Console.ReadLine();



        }
    }
}
