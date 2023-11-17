namespace SurfaceCalc;

/// <summary>
/// Circle as geometrical shape
/// </summary>
public class Circle: Shape, ISurfaceCalculatable
{
    private double _radius;
    
    /// <summary>
    /// Radius of this circle, can not be less than 0.
    /// </summary>
    public virtual double Radius
    {
        get => _radius;
        set
        {
            if (value < 0)
            {
                // Probably should throw an exception
                _radius = 0;
            }
            else
            {
                _radius = value;
            }
        }
    }
    
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    /// <summary>
    /// Calculates surface of this circle.
    /// </summary>
    /// <returns>Surface value</returns>
    public virtual double CalculateSurface()
    {
        return Math.PI * Radius * Radius;
    }
}