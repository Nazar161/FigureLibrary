using FigureLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace FigureApp;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddTransient<IFigureService, FigureService>()
            .BuildServiceProvider();

        IFigureService? figureService = serviceProvider.GetService<IFigureService>();

        if (figureService is null)
        {
            return;
        }

        Circle circle = new Circle(5.0);
        double circleArea = figureService.GetArea(circle);
        Console.WriteLine($"Площадь круга: {circleArea}");

        Triangle triangle = new Triangle(3.0, 4.0, 5.0);
        double triangleArea = figureService.GetArea(triangle);
        Console.WriteLine($"Площадь треугольника: {triangleArea}");
    }
}