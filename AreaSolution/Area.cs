namespace AreaSolution
{
    public class Area
    {
         public static double AreaResult(int r)
        {
            double areaRes = 3.14 * Math.Pow(r, 2);
            return areaRes;
        }
        public static double AreaResult(double[] sides)
        {
            double a = sides[0];
            double b = sides[1];
            double c = sides[2];
            double p = (a + b + c) / 2;
            double areaRes = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            if ((areaRes < 0) || double.IsNaN(areaRes)) return 0;
            else return areaRes;
        }
        public static bool IsTriangleRight(double[] sides)
        {
            Array.Sort(sides);
            double a = sides[0];
            double b = sides[1];
            double angle0 = 180;
            double angle1 = Math.Atan(b / a) * 180/Math.PI;
            double angle2 = Math.Atan(a / b) * 180/Math.PI;  
            if ((angle1 == 90) || (angle2 == 90) || (angle0 - (angle1 + angle2) == 90))
            {
                return true;
            }
            else return false; 
        }
    }
}