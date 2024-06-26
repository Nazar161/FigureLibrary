namespace FigureLibrary.Tests;

public class CircleTests
{
    [Fact]
    public void CalculateCircleArea()
    {
        double radius = 5.0;
        Circle circle = new Circle(radius);

        double area = circle.CalculateArea();
        double expectedArea = Math.PI * Math.Pow(radius, 2);

        Assert.Equal(expectedArea, area, 3);
    }
}