

using System;

namespace Classes
{
    public class Person
    {
        public string Name; // Field - a variable that is declared directly in a class

        public void Introduce(string to) // Instance method - a method that is available on an instance of a class
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        public static Person Parse(string str) // Factory method - a method that creates an object
        {
            var person = new Person
            {
                Name = str
            };

            return person;
        }
    }

    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var person = Person.Parse("Aud");
            person.Introduce("Mosh");
        }
    }
}
