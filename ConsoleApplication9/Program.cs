using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        class Selector
        {
            public static string Buy(string selection)
            {

                //Selector and calculates change

                string quote = " ";
                if (selection.ToUpper() == "A")
                    quote = "Buying a friend? That's a good choice!";
                else if (selection.ToUpper() == "B")
                    quote = "What do you want to buy that for?";
                else if (selection.ToUpper() == "C")
                    quote = "Better have plenty of catfood.  And patience.";
                else if (selection.ToUpper() == "D")
                    quote = "Make sure to put this on wheat bread";
                else if (selection.ToUpper() == "E")
                    quote = "Crab is expensive, bub.";
                else quote = "Don't want anything? Okay bye.";
                return quote;
            }
            public static double Price(string selection)
            {
                double price = 1.00;
                if (selection.ToUpper() == "A")
                    price = 12.99;
                else if (selection.ToUpper() == "B")
                    price = 6.99;
                else if (selection.ToUpper() == "C")
                    price = 10.99;
                else if (selection.ToUpper() == "D")
                    price = 3.99;
                else if (selection.ToUpper() == "E")
                    price = 26.99;
                return price;
            }
            

            
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("A - Dog - 12.99");
            Console.WriteLine("B - Goldfish - 6.99");
            Console.WriteLine("C - Cat - 10.99");
            Console.WriteLine("D - Tunafish - 3.99");
            Console.WriteLine("E - Crab - 26.99");
            Console.Write("Which one do you wish to buy? Enter the letter to select:");
            string selection = Console.ReadLine();
            Console.WriteLine(Selector.Buy(selection));
            Console.WriteLine("Your price for that is {0} ", Selector.Price(selection));
            Console.Write("How much will you pay for that?");
            double pricecheck1 = Selector.Price(selection);
            double amount = double.Parse(Console.ReadLine());
            double change = amount - Selector.Price(selection);
            if (amount < 0)
                Console.WriteLine("Try to enter a real number next time.  Bye.");
            else if (amount < Selector.Price(selection))
                Console.WriteLine("If you can't afford this, go elsewhere.  Bye.");
            else
            Console.WriteLine("Your change is {0} ", change);
            Console.ReadLine();

        }

      
    }
}
