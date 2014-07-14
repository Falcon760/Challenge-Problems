using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q: Reverse and return a string entered by a user.

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            char[] a =name.ToArray();
            Array.Reverse(a);
            Console.WriteLine(a);
            Console.ReadLine();


        }
    }
}
