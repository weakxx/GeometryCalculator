namespace ConsoleApp2.Figures;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentOutOfRangeException("Длины сторон должны быть положительными.");

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("Стороны не могут образовывать треугольник.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter *
                         (semiPerimeter - SideA) *
                         (semiPerimeter - SideB) *
                         (semiPerimeter - SideC));
    }

    public bool IsRightTriangle()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
    }
}