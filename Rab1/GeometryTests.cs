using NUnit.Framework;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryTests
    {
        [Test]
        public void TestCircleArea()
        {
            Circle c = new Circle(5);
            double expected = 78.53981633974483;
            double actual = c.GetArea();
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void TestTriangleAreaSAS()
        {
            Triangle t = new Triangle(Math.PI/4, Math.PI/2,(double)3, (double)4, (double)5);
            double expected = 6;
            double actual = t.GetArea();
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void TestTriangleAreaSSA()
        {
            Triangle t = new Triangle(Math.PI/3, Math.PI/2, 3, 4, true);
            double expected = 2.598;
            double actual = t.GetArea();
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void TestTriangleAreaASA()
        {
            Triangle t = new Triangle(Math.PI/2, 5, 3, 4, false, true);
            double expected = 3;
            double actual = t.GetArea();
            Assert.AreEqual(expected, actual, 0.0001);
        }
        [Test]
        public void TestTriangleAreaAAS()
        {
            Triangle t = new Triangle(Math.PI/6, 4, 5, 3, false, false, true);
            double expected = 3;
            double actual = t.GetArea();
            Assert.AreEqual(expected, actual, 0.0001);
        }
        [Test]
        public void TestRightTriangle()
        {
            Triangle t = new Triangle(Math.PI/2, (double)3, (double)4, (double)5, true);
            bool expected = true;
            bool actual = t.IsRightTriangle();
            Assert.AreEqual(expected, actual);
        }
    }
}