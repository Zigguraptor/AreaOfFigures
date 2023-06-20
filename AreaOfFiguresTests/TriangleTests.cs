using AreaOfFigures.Shapes;

namespace AreaOfFiguresTests;

[TestClass]
public class TriangleTests
{
    private List<Triangle> _isoscelesTriangles;
    private List<Triangle> _equilateralTriangles;
    private List<Triangle> _rightTriangles;

    [TestInitialize]
    public void Init()
    {
        _isoscelesTriangles = new List<Triangle>
        {
            new(3f, 3f, 5f),
            new(4f, 3f, 3f),
            new(3f, 4f, 3f)
        };

        _equilateralTriangles = new List<Triangle>
        {
            new(3f, 3f, 3f),
            new(1000f, 1000f, 1000f),
            new(3.5f, 3.5f, 3.5f)
        };

        _rightTriangles = new List<Triangle>
        {
            new(3f, 4f, 5f),
            new(4f, 3f, 5f),
            new(5f, 4f, 3f),
            new(65f, 72f, 97f)
        };
    }

    [TestMethod]
    public void ImpossibleTriangles_Test()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(0f, 4f, 5f));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(4f, 0f, 5f));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(5f, 4f, 0f));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(0f, 4f, -9789f));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(5f, -4f, 0f));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(-65f, 72f, 97f));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(1165f, 72f, 97f));
    }

    [TestMethod]
    public void Area_Test()
    {
        Assert.AreEqual(2340f, new Triangle(65f, 72f, 97f).Area);
        Assert.AreEqual(3.8971143f, new Triangle(3f, 3f, 3f).Area);
        Assert.AreEqual(8.944272f, new Triangle(6f, 7f, 3f).Area);
    }
}
