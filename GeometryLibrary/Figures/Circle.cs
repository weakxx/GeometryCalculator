namespace ConsoleApp2.Figures;


public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Радиус не может быть отрицательным.");
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
