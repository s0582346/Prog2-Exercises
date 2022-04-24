using System;
using GeometryLibrary;
using MathLibrary;

namespace GeometryLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point startPoint = new Point(1, 2, 3);
            Point endPoint = new Point(4, 5, 6);

            Line l1 = new Line(startPoint, endPoint);

            Console.WriteLine($"The length of the new line is: {l1.Length}\n");

            Console.WriteLine($"The normal vector between the start- and endpoint of the new line is: \n{l1.Direction}\n");



            Point centerPoint = new Point(2, 3, 4);
            Vector normal = centerPoint.AsVector().Normalize();
            double radius = 10;

            Circle c1 = new Circle(centerPoint, normal, radius);
            Console.WriteLine($"The circumference of the circle with given radius: {radius} is: {c1.Length}\n");



            // Polyline

            Random rand = new Random();
            int randNum = rand.Next(1, 4);           
            
            Point p2 = new Point(randNum, 9, 8);
            Point p3 = new Point(5, 6, 7);
            Point p4 = new Point(randNum, 9, 8);
        
            Point[] pointArr = new Point[] { p2, p3, p4};

            Polyline poly = new Polyline(pointArr);

            Console.WriteLine($"Is the following polyline close?\n");

            for (int i = 0; i <= pointArr.Length - 1; i++)
            {
                Console.WriteLine($"{pointArr[i]} \n");
            }
            Console.WriteLine(poly.IsClosed);

  
            Console.WriteLine("------");

            Console.WriteLine($"Does it has more than one point? {poly.IsValid}");

            Console.WriteLine("------");

            Console.WriteLine($"And is it planar? {poly.IsPlanar}");

            Console.WriteLine("------");

            Console.WriteLine($"The length of the polyline is: {poly.Length}\n");
        }
    }
}
