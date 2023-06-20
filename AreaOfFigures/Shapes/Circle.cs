using AreaOfFigures.Interfaces;

namespace AreaOfFigures.Shapes;

public class Circle : IShape
{
    public Circle(float radius)
    {
        if (radius <= 0f)
            throw new ArgumentException("Impossible circle");

        Radius = radius;
    }

    public float Radius { get; }
    public float? Area => Radius > 0 ? Radius * Radius * float.Pi : null;
}
