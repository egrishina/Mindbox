namespace Mindbox
{
    public class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("The length of a side of a triangle should be a positive value.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("The given triangle is not valid.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public bool IsRightAngled => ((SideA * SideA) + (SideB * SideB)) == (SideC * SideC);

        public override double CalculateArea()
        {
            var s = (SideA + SideB + SideC) / 2;
            var area = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            return area;
        }
    }
}
