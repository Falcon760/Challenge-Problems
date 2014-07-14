using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
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


            //Q: Find the largest of 3 numbers by asking a user for them
            Console.WriteLine("We will find the largest of any three numbers you give us.");
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());


            int x = Number.FindtheLargest(num1, num2, num3);

            Console.WriteLine("The largest number of the list is {0}", x);

            Console.ReadLine();
        }
    }
}