using System;

namespace GeometricLibrary
{
    /// <summary>
    /// Точка на плоскости.
    /// </summary>
    public struct PlanarPoint
    {
        /// <summary>
        /// Абсцисса.
        /// </summary>
        public Double X { get; }

        /// <summary>
        /// Ордината.
        /// </summary>
        public Double Y { get; }

        /// <summary>
        /// Конструктор, создающий точку по значениям абсциссы и ординаты.
        /// </summary>
        /// <param name="x">Абсцисса точки (значение по умолчанию 0).</param>
        /// <param name="y">Ордината точки (значение по умолчанию 0).</param>
        public PlanarPoint(Double x = 0, Double y = 0)
        {
            X = x;
            Y = y;
        }

        public Double DistanceTo(PlanarPoint anotherPoint)
        {
            var dx = X - anotherPoint.X;
            var dy = Y - anotherPoint.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}