using System;

namespace GeometricLibrary
{
    public static class MathHelper
    {
        public static Boolean IsNear(this Double x, Double y, Double eps = Double.Epsilon) => Math.Abs(x - y) <= eps;

        public static Boolean IsPythagoreanTriple(Double a, Double b, Double c) => (a * a + b * b).IsNear(c * c);
    }
}