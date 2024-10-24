using ConsoleApp2;
using ConsoleApp2.Figures;
using Xunit;

namespace Test;
public class GeometryLibraryTests
{
    [Fact]
    public void CircleAreaTest()
    {
        Circle circle = new Circle(5);
        double result = AreaCalculator.CalculateShapeArea(circle);
        Assert.Equal(78.53981633974483, result, 5); // Проверка с 5 знаками после запятой
    }

    [Fact]
    public void TriangleAreaTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double result = AreaCalculator.CalculateShapeArea(triangle);
        Assert.Equal(6, result, 5); // Площадь треугольника
    }

    [Fact]
    public void RightTriangleTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void NotRightTriangleTest()
    {
        Triangle triangle = new Triangle(5, 5, 6);
        Assert.False(triangle.IsRightTriangle());
    }

    [Fact]
    public void TriangleInvalidSidesTest()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Fact]
    public void CircleNegativeRadiusTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }

    [Fact]
    public void TriangleNegativeSidesTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 3));
    }
}
