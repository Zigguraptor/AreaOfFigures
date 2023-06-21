namespace AreaOfFigures;

public abstract class Shape
{
    protected float? AreaCache;
    public abstract float Area { get; }

    protected bool FloatCompare(float float1, float float2)
    {
        return float.Abs(float.Abs(float1) - float.Abs(float2)) <= float.Epsilon;
    }
}
