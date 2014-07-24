using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        
        //public static void QueryDB()
        //{
        //    var query = from x in db.Students
        //                select x;
        //    foreach (var item in query)
        //    {
        //        Console.WriteLine(item.FirstName);
        //    }



        //}
        static void Main(string[] args)
        {
            var db = new Database2Entities();
            var address1 = new Address
            {
                City = "Flint",
                State = "MI",
                Street1 = "100 Main",
                Zip = "48084"

            };
           

            var student1 = new Student
            {  
                FirstName = "John",
                LastName = "Smith",
                MiddleName = "J",
                DateOfBirth = DateTime.Parse("1990 - 01 - 05"),
                


            };
           // db.Addresses.Add(address1);
            //db.Students.Add(student1);
            //db.SaveChanges();

            var query = from x in db.Students
                        select x;
            foreach (var item in query)
            {
                Console.WriteLine("First Name = {0} Last Name = {1}", item.FirstName, item.LastName);
            }

            Console.ReadLine();

        }
    }
}
