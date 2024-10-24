using ConsoleApp2.Figures;

class Program
{
    static void Main(string[] args)
    {
        // Пример использования
        Circle circle = new Circle(5);
        double area = circle.CalculateArea();
        Console.WriteLine($"Площадь круга: {area}");         
        Triangle triangle = new Triangle(3, 4, 5);        
        area = triangle.CalculateArea();         
        Console.WriteLine($"Площадь треугольника: {area}");
    }
}