using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public class Number
        {
            


        }
        static void Main(string[] args)
        {
            int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Random num = new Random();
            int num2 = num.Next(1, 10);
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            for (int i = 0; i < list.Length; i++)
            {


                if (guess == num2)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Not correct!  What's your next guess? ");
                    guess = int.Parse(Console.ReadLine());
                }


            }
        }
    }
}
