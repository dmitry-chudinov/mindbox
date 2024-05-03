namespace MindboxTestAssignment.Tests;

public class TriangleTests
{
    [Test]
    [TestCase(1.0, 2.0, 3.0)]
    [TestCase(1.0, 2.0, 5.0)]
    public void InvalidTriangleTest(double a, double b, double c)
    {
        Assert.That(() => new Triangle(a, b, c), Throws.InvalidOperationException);
    }    
    
    [Test]
    [TestCase(1.0, 1.1, 1.2)]
    public void ValidTriangleTest(double a, double b, double c)
    {
        Assert.That(() => new Triangle(a, b, c), Throws.Nothing);
    }
    
    [Test]
    [TestCase(1.0, 1.0, 1.4142135623730950488)]
    public void RightTriangleTests(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.IsRightTriangle(), Is.True);
    }
    
    [Test]
    [TestCase(1.0, 1.1, 1.2)]
    public void NonRightTriangleTests(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.That(triangle.IsRightTriangle(), Is.False);
    }
}