using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(40);
            array.Add(4);
            array.Add(20);
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadLine();

        }
    }
}
