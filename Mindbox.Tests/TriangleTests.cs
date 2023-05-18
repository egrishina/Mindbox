namespace Mindbox.Tests
{
    public class TriangleTests
    {
        private const double Precision = 0.0001;

        [TestCase(4.5, 5.1, 7.6)]
        public void Triangle_IsInstanceOfShape(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.That(triangle, Is.InstanceOf<Shape>());
        }

        [TestCase(4.5, 5.1, 7.6)]
        public void CalculateAreaTriangle_IsCorrect(double sideA, double sideB, double sideC)
        {
            var expected = 11.1090;
            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.CalculateArea();
            Assert.That(actual, Is.EqualTo(expected).Within(Precision));
        }

        [TestCase(0, 0, 0)]
        [TestCase(-4.5, -5.1, -7.6)]
        [TestCase(1.3, 2.8, 15.4)]
        public void CalculateAreaTriangle_InvalidInput_ThrowsException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}