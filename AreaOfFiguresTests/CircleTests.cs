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
        var r = -5f;

        var circle = new Circle(r);
        Assert.IsNull(circle.Area);
    }

    [TestMethod]
    public void Area_Radius0()
    {
        var r = 0f;

        var circle = new Circle(r);
        Assert.IsNull(circle.Area);
    }
}
