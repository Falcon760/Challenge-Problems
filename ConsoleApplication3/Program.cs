using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Write a program that picks a random number and asks the user to guess it.


namespace ConsoleApplication3
{
    class Program
    {
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
                    int guess2 = int.Parse(Console.ReadLine());
                    guess = guess2;
                }
            }
            Console.ReadLine();
 

        }
    }
}
