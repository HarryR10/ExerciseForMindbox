using NUnit.Framework;
using CalculateSq;
using System;

namespace UnitTests
{
    public class Tests
    {
        private double Eps = 0.00000000000001;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Triangle_IsRectangular()
        {
            var triangle = new Triangle(
                new Point(0, 0),
                new Point(0, 4),
                new Point(6, 0));

            Assert.True(triangle.IsRectangular());

            var triangle2 = new Triangle(
                new Point(-5, 1),
                new Point(-2, 0.53),
                new Point(-2.47, -2.47));
            Assert.True(triangle2.IsRectangular(Eps));
        }

        [Test]
        public void Triangle_CalculateSq()
        {
            IFigure triangle = new Triangle(
                new Point(0, 0),
                new Point(0, 4),
                new Point(6, 0));

            Assert.True(Math.Abs(triangle.CalculateSq() - 12) <= Eps);
        }

        [Test]
        public void Circle_CalculateSq()
        {
            IFigure circle = new Circle(
                new Point(0, 0), 16);

            Assert.True(Math.Abs(circle.CalculateSq() - 804.247719318987) <= Eps);
        }
    }
}