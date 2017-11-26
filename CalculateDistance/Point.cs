using System;
using System.Collections.Generic;

namespace CalculateDistance
{
    class Program

    {
        static void Main()
        {
            Point p1 = new Point(2, 2);
            Point p2 = new Point(4, 4);

            Console.WriteLine("Distance between points is : ");
            Console.WriteLine(p1.CalcDistance(p2));

        }
    }

    public class Point
    {
        private int xCoord; // Not visible outside the class
        private int yCoord;

        public Point(int xCoord, int yCoord) // Constructor - same name as class
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public double CalcDistance(Point p)
        {
            return Math.Sqrt(
                (p.xCoord - this.xCoord) * (p.xCoord - this.xCoord) +
                (p.yCoord - this.yCoord) * (p.yCoord - this.yCoord));
        }
    }
}
