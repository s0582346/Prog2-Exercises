
using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace GeometryLibrary
{
    public class Line : Curve
    {
       public Point StartPoint { get; set; }
       public Point EndPoint { get; set; }
       
       public override double Length { get => StartPoint.DistanceTo(EndPoint); }

       public Vector Direction { get => EndPoint.AsVector().Subtract(StartPoint.AsVector()).Normalize(); }

       /// <summary>
       /// Initializes a new line with give startpoint and endpoint
       /// </summary>
       /// <param name="startPoint"></param>
       /// <param name="endPoint"></param>
       public Line(Point startPoint, Point endPoint)
       {
            StartPoint = startPoint;
            EndPoint = endPoint;
       }

       

    }
}
