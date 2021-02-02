using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer{FirstName = "Enes" }, new Student{FirstName = "Engin" }, new Person{FirstName = "Derin"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    interface IPerson
    {

    }

    class Customer : Person , IPerson
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public int SchollNumber { get; set; }
    }
}
