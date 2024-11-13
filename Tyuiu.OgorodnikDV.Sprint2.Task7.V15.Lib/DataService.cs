using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.OgorodnikDV.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y) => y >= 0 && x * x + y * y <= 4 && x * x + y * y >= 1;
        
    }
}
