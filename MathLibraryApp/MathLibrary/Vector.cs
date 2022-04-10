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
            double YZ = b.Z * Y;
            double ZY = b.Y * Z;

            double ZX = b.Z * X;
            double XZ = b.X * Z;

            double XY = b.X * Y;
            double YX = b.Y * X;

            return new Vector(YZ - ZY, ZX - XZ, XY - YX);
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
            double result1 = X / b.X;
            double result2 = Y / b.Y;
            double result3 = Z / b.Z;

            double tol1 = result1 - result2;
            double tol2 = result2 - result3;
            double tol3 = result1 - result3;

            bool areCollinear = false;

            if(result1 == result2 && result1 == result3)
            {
                if(tol1 < tolerance && tol2 < tolerance && tol3 < tolerance)
                {
                    areCollinear = true;
                }
            }

            return areCollinear; 
         
        }

    }
}
