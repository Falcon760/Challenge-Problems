using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = new string[] { "Some", "of", "the", "people", "are", "stupid" };
            string strings2 = "This very large array is stupid";
            var strings3 = strings2.Split(' ');
            var strings4 = strings3.Reverse();
            string joined = String.Join(" ", strings4);
            foreach (var item in joined)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
    }
}
