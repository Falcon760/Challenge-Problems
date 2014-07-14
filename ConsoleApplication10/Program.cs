using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {

            //age message program

            Console.WriteLine("Hey, what is your age?");
            int age = int.Parse(Console.ReadLine());

            if (age < 16)
            {
                Console.WriteLine("You are a minor.");
                Console.WriteLine("You can't drive yet.  Bummer.");
            }
            if (age < 18)
                Console.WriteLine("You can't vote.");
            if (age < 25)
                Console.WriteLine("You can't rent a car.");
            if (age >= 25)
                Console.WriteLine("You can do anything legal.");

            Console.ReadLine();
        }
    }
}
