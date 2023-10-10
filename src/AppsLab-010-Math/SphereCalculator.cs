namespace AppsLab_010_Math;
public class SphereCalculator
{
    
    public double CalculateSurface(double radius)
    {
        
        double PI = Math.PI;
        double result = 4 * PI * Math.Pow (radius, 2);
        return result;
    }
    public double CalculateVolume(double radius)
    {
        {
            double PI = Math.PI;
            double result = ((float)4 / 3.0) * PI * Math.Pow(radius , 3);
            return result;
        }
    }



}
