namespace MindboxTestAssignment;

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius <= double.Epsilon)
        {
            throw new InvalidOperationException("Circle radius should be > 0");
        }

        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}