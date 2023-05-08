
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void UseOutModifier() // this is considered a code smell
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }


            int number;
            var result = int.TryParse("abc", out number); // TryParse returns a boolean and does not throw an exception
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                var point2 = new Point(30, 40);
                point.Move(null); // Throws an exception
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200); // This is fine
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                
                point.Move(point2); // This is fine
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
