using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KarnaukhovDA.Sprint2.Task2.V17.Lib
{
    public class DataService : ISprint2Task2V17
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (y == 3)
            {
                if (x == 3 || x == 4 || x == 5 || x == 6 || x == 7 || x == 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 4)
            {
                if (x == 3 || x == 4 || x == 5 || x == 6 || x == 7 || x == 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 5)
            {
                if (x == 3 || x == 4 || x == 5 || x == 6 || x == 7 || x == 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 6)
            {
                if (x >= 5 && x <= 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 7)
            {
                if (x >= 5 && x <= 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 8)
            {
                if (x >= 5 && x <= 7)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 9)
            {
                if (x >= 3 && x <= 7)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 10)
            {
                if (x >= 3 && x <= 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 11)
            {
                if (x == 3 || x == 4 || x == 5 || x == 10 || x == 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 12)
            {
                if (x == 3 || x == 4 || x == 5 || x == 10 || x == 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (y == 13)
            {
                if (x == 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
