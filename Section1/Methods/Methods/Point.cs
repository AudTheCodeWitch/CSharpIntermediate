using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y) // Constructor with two parameters
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y) // Method with two parameters. Void means no return value.
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation) // Method overloading with one parameter
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation"); // example of defensive programming

            Move(newLocation.X, newLocation.Y);
        }
    }
}