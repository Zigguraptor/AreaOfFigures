namespace AreaOfFigures;

public class Circle : Shape
{
    public Circle(float radius)
    {
        if (radius <= 0f)
            throw new ArgumentException("Impossible circle");

        Radius = radius;
    }

    public float Radius { get; }

    public override float Area
    {
        get
        {
            AreaCache ??= Radius * Radius * float.Pi;
            return (float)AreaCache;
        }
    }

    public override bool Equals(object? obj)
    {
        return obj is Circle temp && FloatCompare(Radius, temp.Radius);
    }

    public override int GetHashCode()
    {
        return Radius.GetHashCode();
    }

    public override string ToString()
    {
        return $"Radius = {Radius}, Area = {Area}";
    }
}
