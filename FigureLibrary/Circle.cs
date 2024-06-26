namespace FigureLibrary;

public class Circle : Figure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Радиус не может быть отрицательным");
        }

        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}