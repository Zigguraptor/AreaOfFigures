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

    public float? Area
    {
        get
        {
            var edges = new float[3];
            edges[0] = A;
            edges[1] = B;
            edges[2] = C;
            Array.Sort(edges);
            if (edges[2].Equals(float.Sqrt(edges[0] * edges[0] + edges[1] * edges[1])))
                return edges[0] * edges[1] / 2;

            var p = (A + B + C) / 2;
            return float.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is Triangle temp)
            return A.Equals(temp.A) && B.Equals(temp.B) && C.Equals(temp.C);

        return false;
    }

    public override int GetHashCode()
    {
        var hash = 17;
        hash = 486187739 * hash + A.GetHashCode();
        hash = 486187739 * hash + B.GetHashCode();
        hash = 486187739 * hash + C.GetHashCode();

        return hash;
    }

    public override string ToString()
    {
        return $"A = {A}, B = {B}, C = {C}";
    }
}
