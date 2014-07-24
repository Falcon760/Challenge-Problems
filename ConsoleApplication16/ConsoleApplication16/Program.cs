using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Movie
    {
        public string Name { get; set; }
        public int Length { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            v

            var movieDictionary = new Dictionary<int, Movie>();
            movieDictionary.Add(1, new Movie
            { Name="Star Wers", Length=120}
                );

            var item = movieDictionary[1];

            Console.WriteLine("{0} - {1} minutes", item.Name, item.Length);

            Console.ReadLine();
        }
    }
}
