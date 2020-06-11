using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateSq
{
    public class Triangle : IFigure
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns></returns>
        public double CalculateSq()
        {
            double AB = CalculateSideLength(A, B);
            double BC = CalculateSideLength(B, C);
            double CA = CalculateSideLength(C, A);

            double halfPerimeter = (AB + BC + CA) / 2;

            double result = halfPerimeter *
                    (halfPerimeter - AB) *
                    (halfPerimeter - BC) *
                    (halfPerimeter - CA);

            return Math.Sqrt(result);
        }

        private double CalculateSideLength(Point first, Point second)
        {
            return
                Math.Sqrt(
                Math.Pow(second.X - first.X, 2) +
                Math.Pow(second.Y - first.Y, 2));
        }

        /// <summary>
        /// Проверка треугольника на то, является ли он прямоугольным
        /// </summary>
        /// <param name="eps">Точность</param>
        /// <returns></returns>
        public bool IsRectangular(double eps)
        {
            double AB = CalculateSideLength(A, B);
            double BC = CalculateSideLength(B, C);
            double CA = CalculateSideLength(C, A);

            if (CalculateAngle(AB, BC, CA) - 90 <= eps ||
                CalculateAngle(BC, CA, AB) - 90 <= eps ||
                CalculateAngle(CA, AB, BC) - 90 <= eps)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Проверка треугольника на то, является ли он прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            double AB = CalculateSideLength(A, B);
            double BC = CalculateSideLength(B, C);
            double CA = CalculateSideLength(C, A);

            if (CalculateAngle(AB, BC, CA).Equals(90) ||
                CalculateAngle(BC, CA, AB).Equals(90) ||
                CalculateAngle(CA, AB, BC).Equals(90))
            {
                return true;
            }
            return false;
        }

        private double CalculateAngle(double a, double b, double c)
        {
            return
                Math.Acos(
                    (
                    Math.Pow(b, 2) +
                    Math.Pow(c, 2) -
                    Math.Pow(a, 2)) / (2 * b * c)) *
                    (180 / Math.PI);
        }
    }
}
