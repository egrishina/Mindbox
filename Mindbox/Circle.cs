namespace Mindbox
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius should be a positive value.", nameof(radius));
            }

            Radius = radius;
        }

        public double Radius { get; }

        public override double CalculateArea()
        {
            var area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
