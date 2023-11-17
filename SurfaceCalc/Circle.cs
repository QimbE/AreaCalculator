namespace SurfaceCalc;

public class Circle: Shape, ISurfaceCalculatable
{
    private double _radius;
    
    public double Radius
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
    
    public double CalculateSurface()
    {
        return Math.PI * Radius * Radius;
    }
}