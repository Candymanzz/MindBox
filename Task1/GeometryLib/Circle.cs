namespace GeometryLib
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным.", nameof(radius));
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}