
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using MathLibrary;


namespace GeometryLibrary
{
    public class Line : Curve
    {
       public MathLibrary.Point StartPoint { get; set; }
       public MathLibrary.Point EndPoint { get; set; }
      
       public override void Draw(Graphics g)
       {
            g.DrawLine(DrawPen, (float)StartPoint.X, (float)StartPoint.Y, (float)EndPoint.X, (float)EndPoint.Y );
       }

       public override double Length { get => StartPoint.DistanceTo(EndPoint); }

       public Vector Direction { get => EndPoint.AsVector().Subtract(StartPoint.AsVector()).Normalize(); }

       /// <summary>
       /// Initializes a new line with give startpoint and endpoint
       /// </summary>
       /// <param name="startPoint"></param>
       /// <param name="endPoint"></param>
       public Line(MathLibrary.Point startPoint, MathLibrary.Point endPoint)
       {
            StartPoint = startPoint;
            EndPoint = endPoint;
       }

       

    }
}
