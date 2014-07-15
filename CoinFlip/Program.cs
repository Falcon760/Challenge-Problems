using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Coin
    {
        private static Random num = new Random();
        public static void Flip(int times)
        {
            int heads = 0;
            int tails = 0;
            for (int i = 0; i < times; i++)
            {
                

                if (num.Next(2) == 1)
                {
                    Console.WriteLine("HEADS");
                    heads++;
                }
                else
                {
                    Console.WriteLine("TAILS");
                    tails++;
                }
            }
            Console.WriteLine("{0} instances of heads and {1} instances of tails.", heads, tails);
            double percent1 = ((double)heads/(double)times);
           double percent2 = ((double)tails/(double)times);
            Console.WriteLine("This equates to {0:P2} percent of heads and {1:P2} percent of tails.", percent1, percent2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                Coin.Flip(100);

          
            Console.ReadLine();

        }
    }
}
