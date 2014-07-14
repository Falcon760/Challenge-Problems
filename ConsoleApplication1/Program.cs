using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
      
        class Student
        {
            public int StudentID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        class Dog
        {
            public int DogID { get; set; }
            public int Age { get; set; }
            public string Name { get; set; }
            public string Species { get; set; }
        }

        public class Getter
        {
            public static void Get(object x)
            {
                object y = x.GetType();
                Console.WriteLine(y);
                

            }

        }


        static void Main(string[] args)
        {
            //write a program that prints all the information about a class
           
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(x))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(x);
                Console.WriteLine("{0}={1}", name, value);
            }

            Console.ReadLine();

        }
    }
}
