namespace MindboxTestAssignment.Tests;

public class CircleTests
{
    [Test]
    [TestCase(-0.5)]
    [TestCase(-0.0)]
    [TestCase(0.0)]
    public void InvalidCircleTest(double radius)
    {
        Assert.That(() => new Circle(radius), Throws.InvalidOperationException);
    }    
    
    [Test]
    [TestCase(0.1)]
    [TestCase(0.5)]
    [TestCase(5.0)]
    public void ValidCircleTest(double radius)
    {
        Assert.That(() => new Circle(radius), Throws.Nothing);
    }
}