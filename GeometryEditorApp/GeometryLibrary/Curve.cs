using System;
using MathLibrary;
using System.Drawing;

namespace GeometryLibrary
{
    public abstract class Curve
    {
        public virtual Pen DrawPen { get; set; } = new Pen(Color.Black);
        public abstract double Length { get; }

        public abstract void Draw(Graphics g);
    }
}
