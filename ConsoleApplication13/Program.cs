using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "This C# is some easy stuff.";
            //Console.WriteLine("The original sentence was {0} {1} {0}", Environment.NewLine, s1);
            //string s2 = s1.Replace("easy", "hard");
            //Console.WriteLine("The correct sentence is {0} {1} {0}", Environment.NewLine, s2);
            //Console.ReadLine();
            string e1 = "Eat at the Free Food Depot Tuesday night and get something free.";
            int count = 0;    
            foreach (char e in e1)
                {
                    if (e == 'e')
                        count++;
                }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
