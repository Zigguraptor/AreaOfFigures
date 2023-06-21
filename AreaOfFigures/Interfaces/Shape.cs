namespace AreaOfFigures.Interfaces;

public abstract class Shape
{
    protected float? AreaCache;
    public abstract float Area { get; }
}
