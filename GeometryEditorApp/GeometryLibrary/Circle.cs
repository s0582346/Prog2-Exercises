using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MathLibrary;

namespace GeometryLibrary
{
    public class Circle : Curve, ISurface
    {

        public double Area { get => Math.PI * Math.Pow(Radius, 2); }
        public MathLibrary.Point CenterPoint { get; set; }

        public Vector Normal { get; set; }

        public double Radius { get; set; }

        public override double Length { get => Math.PI * Radius * 2; }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(DrawPen, (float)CenterPoint.X, (float)CenterPoint.Y, (float)Radius, (float)Radius);
        }

        /// <summary>
        /// Initializes a new circle 
        /// </summary>
        /// <param name="centerPoint">Point to be the center of the circle</param>
        /// <param name="normal">Normalized vector</param>
        /// <param name="radius">Radius of the circle</param>
        public Circle(MathLibrary.Point centerPoint, Vector normal, double radius)
        {
            CenterPoint = centerPoint;

            Normal = normal;

            Radius = radius;
        }

    }
}
