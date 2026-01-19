using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KarnaukhovDA.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (y >= x * x && y <= 4 && x >= -2 && x <= 3)
                {
                res = true;
                }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
