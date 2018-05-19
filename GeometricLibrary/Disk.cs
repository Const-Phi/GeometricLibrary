using System;

namespace GeometricLibrary
{
    public sealed class Disk : IPlanarShape
    {
        /// <summary>
        /// Конструктор, создающий объект по значению радиуса.
        /// </summary>
        /// <param name="radius">Значение радиуса круга (по умолчанию 0).</param>
        /// <exception cref="ArgumentOutOfRangeException" />
        public Disk(Double radius = 0) => Radius = radius;

        /// <summary>
        /// Значение радиуса (поле).
        /// </summary>
        private Double radius;

        /// <summary>
        /// Радиус круга.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public Double Radius
        {
            get => radius;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Radius), "Radius value must be greater than zero (0).");
                radius = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Метод получения площади круга.
        /// </summary>
        /// <returns></returns>
        public Double GetArea() => Math.PI * Radius * Radius;
    }
}
