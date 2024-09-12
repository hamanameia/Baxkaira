using System.Numerics;

namespace Baxkairas
{
    public class AdalbertoEinstenio
    {
        public static double[] Baxkaira(double a, double b, double c)
        {
            var delta = b * b - 4 * a * c;
            var x1 = (-b + Math.Sqrt(delta))/2*a;
            var x2 = (-b - Math.Sqrt(delta)) / 2 * a;

            if (delta < 0)
            {

                return null;
            }

            

            return new double[] {x1,x2};
        }
    }
}
