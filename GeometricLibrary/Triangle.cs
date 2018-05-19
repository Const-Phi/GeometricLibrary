using System;
using System.Linq;

namespace GeometricLibrary
{
    public sealed class Triangle : IPlanarShape
    {
        private const Int32 numberOfVertex = 3;

        private readonly Double[] sides = new Double[numberOfVertex];

        public Triangle(params Double[] sides)
        {
            if (sides.Length != numberOfVertex)
                throw new ArgumentException("Number of sides of triangle must be equal three (3).", nameof(sides));

            Array.Copy(sides, this.sides, numberOfVertex);
        }

        /// <summary>
        /// Нахождение площади треугольника по формуле Герона S = sqrt(p*(p-a)*(p-b)*(p-c))
        /// </summary>
        /// <returns></returns>
        public Double GetArea()
        {
            var halfOfPerimeter = sides.Sum() / 2;
            var tempValue = halfOfPerimeter;
            foreach (var side in sides)
                tempValue *= halfOfPerimeter - side;
            return Math.Sqrt(tempValue);
        }

        public Boolean IsRight()
        {
            var result = false;
            for (var i = 0; i < numberOfVertex; ++i)
                result = result || MathHelper.IsPythagoreanTriple(sides[i], sides[(i + 1) % numberOfVertex], sides[(i + 2) % numberOfVertex]);
            return result;
        }
    }
}
