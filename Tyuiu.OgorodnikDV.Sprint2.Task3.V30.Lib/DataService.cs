using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.OgorodnikDV.Sprint2.Task3.V30.Lib
{
    public class DataService : ISprint2Task3V30
    {
        public double Calculate(double x)
        {
            double res;
            if (x > 1)
            {
                res = Math.Round(x * (Math.Pow((x + 1) / (x - 1), x)), 3);
                return res;
            }
            else if (x == 0)
            {
                res = Math.Round((Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) - 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) - 2), 3);
                return res;
            }
            else if (x > -34 && x < 2)
            {
                res = Math.Round(Math.Pow((1 + (1 / (Math.Pow(x, 2)))), x), 3);
                return res;
            }
            else if (x < -34)
            {
                res = Math.Round(x + 10 * x - (1 / x), 3);
                return res;
            }
            else
            {
                return 0;
            }
        }
    }
}
