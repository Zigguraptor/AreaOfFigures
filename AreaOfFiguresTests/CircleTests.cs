using AreaOfFigures.Shapes;

namespace AreaOfFiguresTests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void Area_Radius5()
    {
        var r = 5f;
        var expected = 78.5398163375f;

        var circle = new Circle(5);
        Assert.AreEqual(expected, circle.Area);
    }

    [TestMethod]
    public void Area_NegativeRadius()
    {
        Assert.ThrowsException<ArgumentException>(() => new Circle(-1000f));
        Assert.ThrowsException<ArgumentException>(() => new Circle(-1.123f));
    }

    [TestMethod]
    public void Area_Radius0()
    {
        Assert.ThrowsException<ArgumentException>(() => new Circle(0f));
    }
}
