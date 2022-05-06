using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public class Vector : PointVectorBase
    {
        public static readonly Vector Zero = new Vector();
        public static readonly Vector One = new Vector(1, 1, 1);

        public static readonly Vector XDir = new Vector(1, 0, 0);
        public static readonly Vector YDir = new Vector(0, 1, 0);
        public static readonly Vector ZDir = new Vector(0, 0, 1);

       
        public double Length { get => CalculateDistanceTo(Zero); }
        public Vector(double x = 0, double y = 0, double z = 0): base(x, y, z)
        {
        }

        public Vector(Vector sourceVector): base(sourceVector.X, sourceVector.Y, sourceVector.Z)
        {
        }

        public Vector Add(params Vector[] addends)
        {
            return CalculateSum(addends).AsVector();
        }

        public Vector Subtract(params Vector[] subtrahends)
        {
            Vector pvb = new Vector(X, Y, Z);
            foreach (Vector subtrahend in subtrahends)
            {
                pvb.X = pvb.X - subtrahend.X;
                pvb.Y = pvb.Y - subtrahend.Y;
                pvb.Z = pvb.Z - subtrahend.Z;
            }

            return pvb;
        }

        public Vector MultiplyScalar(double scalarFactor)
        {
            return new Vector(scalarFactor * X, scalarFactor * Y, scalarFactor * Z);
        }

        public Vector CrossProduct(Vector b)
        {
            return new Vector(
                Y * b.Z - Z * b.Y,
                Z * b.X - X * b.Z,
                X * b.Y - Y * b.X
            );
        }
        public double DotProduct(Vector b)
        {
            return this.X * b.X + this.Y * b.Y + this.Z * b.Z;
        }

        public Vector Normalize()
        {
            return new Vector(X / Length, Y / Length, Z / Length);
        }

        public bool AreCollinear(Vector b, double tolerance = PointVectorBase.Tolerance)
        {
            Vector cross = this.CrossProduct(b);
            return Math.Abs(cross.X) <= tolerance && Math.Abs(cross.Y) <= tolerance && Math.Abs(cross.Z) <= tolerance;
        }

    }
}
