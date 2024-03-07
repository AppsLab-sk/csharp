namespace AppsLab_010_Math;

/// <summary>
/// Calculates the surface area and volume of a sphere.
/// </summary>
public class SphereCalculator
{
    /// <summary>
    /// Calculates the surface area of a sphere.
    /// </summary>
    /// <param name="radius">The radius of the sphere.</param>
    /// <returns>The surface area of the sphere.</returns>
    public double CalculateSurface(double radius)
    {
        double PI = Math.PI;
        double result = 4 * PI * Math.Pow(radius, 2);
        return result;
    }

    /// <summary>
    /// Calculates the volume of a sphere.
    /// </summary>
    /// <param name="radius">The radius of the sphere.</param>
    /// <returns>The volume of the sphere.</returns>
    public double CalculateVolume(double radius)
    {
        double PI = Math.PI;
        double result = ((float)4 / 3.0) * PI * Math.Pow(radius, 3);
        return result;
    }
}
