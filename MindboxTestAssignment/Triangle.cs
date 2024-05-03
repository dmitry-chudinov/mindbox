namespace MindboxTestAssignment;

public class Triangle : IShape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        void CheckSide(double side, double others)
        {
            const double epsilon = 0.000000001;
            if (others < side + epsilon)
            {
                throw new InvalidOperationException("Any triangle side must be less than sum of other sides");
            }
        }
        
        CheckSide(a, b + c);
        CheckSide(b, a + c);
        CheckSide(c, a + b);
        
        A = a;
        B = b;
        C = c;
    }

    public double CalculateArea()
    {
        var s = (A + B + C) / 2.0;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    public bool IsRightTriangle()
    {
        bool CheckHypotenuse(double hypotenuse, double other1, double other2)
        {
            const double epsilon = 0.000000001;
            return Math.Abs((other1 * other1 + other2 * other2) - (hypotenuse * hypotenuse)) < epsilon;
        }

        bool isRightTriangle;
        if (A >= B && B >= C)
        {
            isRightTriangle = CheckHypotenuse(A, B, C);
        }
        else if (B >= A && B >= C)
        {
            isRightTriangle = CheckHypotenuse(B, A, C);
        }
        else
        {
            isRightTriangle = CheckHypotenuse(C, A, B);
        }

        return isRightTriangle;
    }
}