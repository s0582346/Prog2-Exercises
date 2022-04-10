using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public class PointVectorBase
    {
        public const double Tolerance = 1e-10;

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public PointVectorBase(double x = 0, double y = 0, double z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        protected PointVectorBase(PointVectorBase sourcePvBase) : this(sourcePvBase.X, sourcePvBase.Y, sourcePvBase.Z)
        {
        }

        protected double CalculateDistanceTo(PointVectorBase endPvBase)
        {
            double distance = Math.Sqrt(Math.Pow(this.X - endPvBase.X, 2) + Math.Pow(this.Y - endPvBase.Y, 2) + Math.Pow(this.Z - endPvBase.Z, 2));
            return distance;
        }

        protected PointVectorBase CalculateSum(params Vector[] addends)
        {
            PointVectorBase pvb = new PointVectorBase(X, Y, Z);
            foreach (PointVectorBase addend in addends)
            {
                pvb.X = pvb.X + addend.X;
                pvb.Y = pvb.Y + addend.Y;
                pvb.Z = pvb.Z + addend.Z;
            }
            return pvb;
        }
        public Point AsPoint() => new Point(X, Y, Z);
        public Vector AsVector() => new Vector(X, Y, Z);
        public override string ToString() => $" X: '{X}' \n Y: '{Y}' \n Z: '{Z}'";
    }
}
