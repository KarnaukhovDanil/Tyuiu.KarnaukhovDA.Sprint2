using tyuiu.cources.programming.interfaces.Sprint2;
// ==, !=, <, >, <=, >= x=185 y=251
namespace Tyuiu.KarnaukhovDA.Sprint2.Task0.V8.Lib
{
    public class DataService : ISprint2Task0V8
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 66 == y;
            res[1] = x + 66 != y;
            res[2] = x < y;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = x >= y;

            return res;
        }
    }
}
