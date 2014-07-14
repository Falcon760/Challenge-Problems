using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {

       public class HangmanArray
        {
            enum vowels
            {
                a,
                e,
                i,
                o, 
                u
            }
            public static void GuessAdd(char guess)
            {
                List<char> letterguesses = new List<char>();
                letterguesses.Add(guess);
                letterguesses.ForEach(Console.WriteLine);

            }
            

	
        }
        static void Main(string[] args)
        {
            string[] array1 = { "ferrari", "woman", "child", "forest", "doggy", "pillow", "school", "bike" };
            // char[] delimiter = new char[] { ',' };
            Random num = new Random();
            var a = num.Next(1,8);
            string word = array1[a].ToUpper();
            char[] letters = word.ToCharArray();
            Console.WriteLine("Hello, the word I'm thinking of is {0} letters long", letters.Length);
            for (int i = 50; i > 0; i--)
            {

                Console.WriteLine("You have {0} guesses left", i);
                Console.WriteLine("What is your guess?");
               char guess = char.Parse(Console.ReadLine().ToUpper());
               
                if (word.Contains(guess))
                {
                    Console.WriteLine("Yes, it contains that letter");
                    HangmanArray.GuessAdd(guess);
                    
                }
                else
                {
                    Console.WriteLine("No, it doesn't contain that letter");
                    HangmanArray.GuessAdd(guess);
                }
            };


            Console.WriteLine(word);
            Console.ReadLine();

        }
    }
}
