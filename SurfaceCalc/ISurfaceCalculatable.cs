namespace SurfaceCalc;

/// <summary>
/// Contract to compute surface of something.
/// </summary>
public interface ISurfaceCalculatable
{
    /// <summary>
    /// Calculates surface of instance.
    /// </summary>
    /// <returns>The surface value.</returns>
    double CalculateSurface();
}