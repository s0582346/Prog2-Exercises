using System;
using MathLibrary;

namespace MathLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 6, 4);
            Point p2 = new Point(8, 6, 8);

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"The Distance between point one: \n{p1} \n and two: \n{p2} \n is: {distance} \n ");

            Vector v1 = p1.AsVector();
            Vector v2 = p2.AsVector();

            Vector sub = v1.Subtract(v2);
            Console.WriteLine($"The subtraction between vector one: \n{v1} \n and two: \n{v2} \n is: \n{sub} \n");

            Vector sum = v1.Add(v2);
            Console.WriteLine($"The Sum between vector one: \n{v1} \n and two: \n{v2} \n is: \n{sum} \n");


            Vector v3 = new Vector(4, 5, 6);
            Vector v4 = new Vector(7, 8, 9);

            var rnd= new Random();
            double scalarFactor = rnd.Next(20);
            Vector scalar = v3.MultiplyScalar(scalarFactor);
            Console.WriteLine($"The result between vector: \n{v1} \n multiplied by a random scalar {scalarFactor} is: \n{scalar} \n");

            Vector crossProduct = v3.CrossProduct(v4);
            Console.WriteLine($"The Cross Product between vector: \n{v3} \n and: \n{v4} \n is: \n{crossProduct} \n");

            double dotProduct = v3.DotProduct(v4);
            Console.WriteLine($"The Dot Product between vector: \n{v3} \n and: \n{v4} \n is: {dotProduct} \n");

            Vector v5 = new Vector(1, 2, 3);
            Vector v6 = new Vector(1, 2, 3);

            bool areCollinear = v5.AreCollinear(v6);
            if (areCollinear)
            {
                Console.WriteLine($"Are these vector collinear? \n v5: \n{v5} \n ------ \n v6: \n{v6}: {areCollinear} \n");
            }
            else
            {
                Console.WriteLine($"Are these vector collinear? v5: \n{v5} \n ------ \n v6: \n{v6}: {areCollinear} \n");
            }

            Vector normalizedVector = v6.Normalize();
            Console.WriteLine($"Vector v6: \n{v6} \n normalized: \n{normalizedVector} ");
        }
    }
}
