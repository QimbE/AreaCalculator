namespace SurfaceCalc;

/// <summary>
/// Triangle as geometrical shape.
/// </summary>
public class Triangle: Shape, ISurfaceCalculatable
{
    public virtual double FirstSide { get; private set; }
    public virtual double SecondSide { get; private set; }
    public virtual double ThirdSide { get; private set; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        // If it is not a triangle
        if (!IsTriangle(firstSide, secondSide, thirdSide))
        {
            // Probably should not throw an exception, depends on business logic
            throw new ArgumentException("Triangle with such sides can not exist.");
        }
        
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    /// <summary>
    /// Checks is it a triangle or not based on 3 sides.
    /// </summary>
    /// <param name="firstSide">Side of the triangle</param>
    /// <param name="secondSide">Side of the triangle</param>
    /// <param name="thirdSide">Side of the triangle</param>
    /// <returns></returns>
    protected static bool IsTriangle(double firstSide, double secondSide, double thirdSide)
    {
        //Triangle inequality
        return (firstSide + secondSide > thirdSide) &&
            (firstSide + thirdSide > secondSide) &&
            (secondSide + thirdSide > firstSide);
    }

    /// <summary>
    /// Checks is this triangle right or not.
    /// </summary>
    /// <returns></returns>
    public bool IsRightTriangle()
    {
        // Probably need to handle loss of presicion, depends on business logic
        return (FirstSide * FirstSide + SecondSide * SecondSide == ThirdSide * ThirdSide) ||
               (FirstSide * FirstSide + ThirdSide * ThirdSide == SecondSide * SecondSide) ||
               (SecondSide * SecondSide + ThirdSide * ThirdSide == FirstSide * FirstSide);
    }
    
    /// <summary>
    /// Calculates surface of this triangle instance.
    /// </summary>
    /// <returns>Surface value</returns>
    public virtual double CalculateSurface()
    {
        // Probably should also check if the triangle is right and calculate surface by 2 legs.
        
        // Heron's formula
        double p = (FirstSide + SecondSide + ThirdSide)/2d;
        return Math.Sqrt(
            p * (p-FirstSide) * (p-SecondSide) * (p-ThirdSide)
        );
    }
}