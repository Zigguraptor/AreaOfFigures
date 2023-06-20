using AreaOfFigures.Interfaces;

namespace AreaOfFigures.Shapes;

public class Triangle : IShape
{
    public Triangle(float a, float b, float c)
    {
        if (!IsPossible(a, b, c))
            throw new ArgumentException("Impossible triangle");

        A = a;
        B = b;
        C = c;
    }

    public float A { get; }
    public float B { get; }
    public float C { get; }

    public static bool IsPossible(float a, float b, float c)
    {
        if (a <= 0f && b <= 0f && c <= 0f) return false;

        var ab = a + b;
        var ac = a + c;
        var bc = b + c;

        return ab > c && ac > b && bc > a;
    }

    public float? Area { get; }
}
