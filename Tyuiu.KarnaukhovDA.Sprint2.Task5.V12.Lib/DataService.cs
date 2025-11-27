using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KarnaukhovDA.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevDay, prevMonth, prevYear;

            switch(n)
            {
                case 1:

                    switch (m)
                    {
                        case 1:
                            prevDay = 31;
                            prevMonth = 12;
                            prevYear = g - 1;
                            break;
                        case 3:
                            prevDay = 29;
                            prevMonth = 02;
                            prevYear = g;
                            break;
                        case 2:
                        case 4:
                        case 6:
                        case 8:
                        case 9:
                        case 11:
                            prevDay = 31;
                            prevMonth = m - 01;
                            prevYear = g;
                            break;
                        case 5:
                        case 7:
                        case 10:
                        case 12:
                            prevDay = 30;
                            prevMonth = m - 01;
                            prevYear = g;
                            break;
                            default:
                            return "Введены некорректные данные";

                    }
                    break;
                default:
                    prevDay = n - 01;
                    prevMonth = m;
                    prevYear = g;   
                    break;
            }
            return $"{prevDay:D2}.{prevMonth:D2}.{prevYear}";
        }
    }
}
