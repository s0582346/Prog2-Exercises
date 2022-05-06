using System;
using System.Collections.Generic;
using System.Linq;
using MathLibrary;

namespace GeometryLibrary
{
    /// <summary>
    /// class called polyline which inherits the abstract class called curve 
    /// </summary>
    public class Polyline : Curve
    {


        private List<Point> _points = new List<Point>();
        public IReadOnlyList<Point> Points => _points.AsReadOnly();


        /// <summary>
        /// Proofs if the startpoint and the endpoint of the polyline matches
        /// </summary>
        /// <returns>True or false depending on if polyline is closed  </returns>
        public bool IsClosed
        {
            get
            {
                if (IsValid)
                {
                    if ((_points.First().X == _points.Last().X) && (_points.First().Y == _points.Last().Y) && (_points.First().Z == _points.Last().Z))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Proofs if the points inside the polyline lie in the same plane.
        /// </summary>
        /// <returns>True or false depending on if that´s the case</returns>
        public bool IsPlanar
        {
            get
            {
                if (_points.Count < 3)
                {
                    return false;
                }

                List<Vector> vectors = new List<Vector>();
                for (int i = 1; i < _points.Count; i++)
                {
                    Point currentStart = _points[i - 1];
                    Point currentEnd = _points[i];
                    vectors.Add(CreateVectorBetweenPoints(currentStart, currentEnd));
                }

                List<Vector> crossProducts = new List<Vector>();
                for (int i = 1; i < vectors.Count; i++)
                {
                    Vector currentCrossProduct = vectors[0].CrossProduct(vectors[i]);
                    crossProducts.Add(currentCrossProduct);
                }

                bool allCrossProductsCollinear = true;
                for (int i = 1; i < crossProducts.Count; i++)
                {
                    if (!crossProducts[0].AreCollinear(crossProducts[i]))
                    {
                        allCrossProductsCollinear = false;
                        break;
                    }
                }

                return allCrossProductsCollinear;
            }


        }

        /// <summary>
        /// Proofs if the given polyline has more than one point
        /// </summary>
        /// <returns>True or false depending on if that´s the case</returns>
        public bool IsValid
        {
            get
            {
                if (_points.Count() >= 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Caculates the length between the points inside the polyline 
        /// </summary>
        /// <return>The total length between every point</return>
        public override double Length
        {

            get
            {
                double len = 0;
                for (int i = 0; i < _points.Count() - 1; i++)
                {
                    len = len + Math.Sqrt(Math.Pow(_points[i + 1].X - _points[i].X, 2) + Math.Pow(_points[i + 1].Y - _points[i].Y, 2) + Math.Pow(_points[i + 1].Z - _points[i].Z, 2));
                }
                return len;
            }

        }

        /// <summary>
        /// Adds a new point to the polyline
        /// </summary>
        /// <param name="newPoint">point to add</param>
        public void AddPoint(Point newPoint)
        {
            _points.Add(newPoint);
        }

        /// <summary>
        /// Inserts a new point to the polyline with a given index
        /// </summary>
        /// <param name="index">place that the new point will have</param>
        /// <param name="newPoint">point to insert</param>
        public void InsertPoint(int index, Point newPoint)
        {
            _points.Insert(index, newPoint);
        }

        /// <summary>
        /// Removes a point of the polyline
        /// </summary>
        /// <param name="index">index of the point to be remove</param>
        public void RemovePoint(int index)
        {
            _points.RemoveAt(index);
        }

        /// <summary>
        /// Initializes a polyline adding new points to the list
        /// </summary>
        /// <param name="points">array of points to add</param>
        public Polyline(Point[] points)
        {
            _points = points.ToList();
        }


        private Vector CreateVectorBetweenPoints(Point startPoint, Point endPoint)
        {
            double deltaX = endPoint.X - startPoint.X;
            double deltaY = endPoint.Y - startPoint.Y;
            double deltaZ = endPoint.Z - startPoint.Z;
            return new Vector(deltaX, deltaY, deltaZ);
        }
    }

}
