namespace FigureLibrary.Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateTriangleArea()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double area = triangle.CalculateArea();
        double expectedArea = 6;

        Assert.Equal(expectedArea, area);
    }
}