namespace FigureLibrary;

public class FigureService : IFigureService
{
    public double GetArea(Figure figure)
    {
        return figure.CalculateArea();
    }
}