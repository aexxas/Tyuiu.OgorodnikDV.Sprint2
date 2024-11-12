using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.OgorodnikDV.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x == 2 && ((y == 6) || (y == 7))) || ((3 <= x && x <= 5) && (3 <= y && y <= 7)) || ((6 <= x && x <= 9) && (5 <= y && y <= 9)) || ((x == 6 || x == 7) && (y == 10 || y == 11)) || ((x >= 3 || x <= 5) && y == 11) || (x == 7 && y == 12) || ((x >= 9 && x <= 12) && (y == 8 || y == 9)) || ((x == 11 || x == 12) && (y == 10 || y == 11)) || ((x == 13 || x == 12) && (y == 6 || y == 7)) || (x == 12 && (y <= 3 && y >= 5)))
            {
                res = true;
                return res;
            }
            else
            {
                res = false;
                return res;
            }
        }
    }
}
