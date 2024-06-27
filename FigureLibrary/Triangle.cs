namespace FigureLibrary;

public class Triangle : Figure
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Стороны треугольника не могут быть отрицательными");
        }

        // Проверка существования треугольника
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("Сумма любых двух сторон треугольника должна быть больше третьей стороны");
        }

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public override double CalculateArea()
    {
        double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) *
                         (semiPerimeter - _sideC));
    }

    public bool IsRightAngledTriangle()
    {
        List<double> sides = [_sideA, _sideB, _sideC];
        sides.Sort();

        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 0.00001;
    }
}