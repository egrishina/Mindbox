namespace Mindbox.Tests
{
    public class CircleTests
    {
        private const double Precision = 0.0001;

        [TestCase(7.5)]
        public void Circle_IsInstanceOfShape(double radius)
        {
            var circle = new Circle(radius);
            Assert.That(circle, Is.InstanceOf<Shape>());
        }

        [TestCase(7.5)]
        public void CalculateAreaCircle_IsCorrect(double radius)
        {
            var expected = Math.PI * 7.5 * 7.5;
            var circle = new Circle(radius);
            var actual = circle.CalculateArea();
            Assert.That(actual, Is.EqualTo(expected).Within(Precision));
        }

        [TestCase(0)]
        [TestCase(-7.5)]
        public void CalculateAreaCircle_InvalidInput_ThrowsException(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}