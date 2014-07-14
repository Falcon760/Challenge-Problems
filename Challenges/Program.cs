using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
   
   
    class Program
    {
        class Number
        { 
        public static int FindtheLargest(int a, int b, int c)
        {
            int biggest = a;
            if (b > biggest)
                biggest = b;
            if (c > biggest)
                biggest = c;
            return biggest;
        }

        }
        static void Main(string[] args)
        {

      
            //Q: Find the largest of 3 numbers

            int x = Number.FindtheLargest(99, 2, 3);
          
            Console.WriteLine("The largest number of the list is {0}", x);

            Console.ReadLine();

        }
    }
}
