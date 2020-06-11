using System;
namespace CalculateSq
{
    public class Circle : IFigure
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        public double CalculateSq()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
