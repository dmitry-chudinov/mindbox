namespace MindboxTestAssignment.Tests;

public class ShapeAreaTests
{
    [Test]
    [TestCase(0.5, 0.785398163397448309615660845820)]
    [TestCase(1.0, 3.14159265358979323846264338328)]
    [TestCase(2.0, 12.5663706143591729538505735331)]
    public void CircleTest(double radius, double expectedArea)
    {
        var circle = new Circle(radius);
        var area = circle.CalculateArea();
        Assert.That(Math.Abs(area - expectedArea), Is.LessThan(double.Epsilon));
    }   
    
    [Test]
    [TestCase(1.0, 2.0, 2.5, 0.949917759598166476979296512877)]
    [TestCase(2.5, 1.0, 2.0, 0.949917759598166476979296512877)]
    [TestCase(2.0, 2.5, 1.0, 0.949917759598166476979296512877)]
    [TestCase(100.0, 101.0, 102.0, 4416.29646168596792946702587770)]
    public void TriangleTest(double a, double b, double c, double expectedArea)
    {
        var triangle = new Triangle(a, b, c);
        var area = triangle.CalculateArea();
        Assert.That(Math.Abs(area - expectedArea), Is.LessThan(double.Epsilon));
    }
}