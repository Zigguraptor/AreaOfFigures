using AreaOfFigures.Interfaces;

namespace AreaOfFigures.Shapes;

public class Circle : Shape
{
    public Circle(float radius)
    {
        if (radius <= 0f)
            throw new ArgumentException("Impossible circle");

        Radius = radius;
    }

    public float Radius { get; }
    public override float Area => Radius * Radius * float.Pi;
}
