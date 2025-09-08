namespace GeometryLib
{
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными.");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует.");
            }

            A = a; B = b; C = c;
        }

        public double GetArea()
        {
            double s = (A + B + C) / 2.0;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public bool IsRightAngled()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);
            double a2b2 = Math.Round(sides[0] * sides[0] + sides[1] * sides[1], 6);
            double c2 = Math.Round(sides[2] * sides[2], 6);
            return Math.Abs(a2b2 - c2) < 1e-6;
        }
    }
}