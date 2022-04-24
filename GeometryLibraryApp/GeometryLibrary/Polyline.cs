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
                if(IsValid)
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
                if (_points.Count >= 3)
                {
                    Vector firstNormalvec = new Vector(_points[0].AsVector()).Subtract(_points[1].AsVector()).Normalize().CrossProduct(new Vector(_points[1].AsVector()).Subtract(_points[2].AsVector()).Normalize());

                    for (int j = 1; j < _points.Count - 2; j++)
                    {

                        Vector compareVec = new Vector(_points[j].AsVector()).Subtract(_points[j + 1].AsVector()).Normalize().CrossProduct(new Vector(_points[j + 1].AsVector()).Subtract(_points[j + 2].AsVector()).Normalize());
                        if (!compareVec.AreCollinear(firstNormalvec))
                        {
                            return false;
                        }
                    }
                    return true;

                }

                return false;

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
    }   
        
}
