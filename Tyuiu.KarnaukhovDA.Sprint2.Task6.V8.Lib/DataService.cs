using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KarnaukhovDA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if ( n == 1 && m == 1 )
            {
                throw new ArgumentException("Дата не должна быть 1 января");
            }
            
            int prevDay, prevMonth;

            if ( m == 1 )
            {
                prevMonth = n - 1;

                switch (prevMonth)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        prevDay = 31;
                        break;
                    case 4: case 6: case 9: case 11:
                        prevDay = 30;
                        break;
                    case 2:
                        prevDay = 28;
                        break;
                        default:
                        throw new ArgumentException("Неверный номер месяца");
                }
            }
            else
            {
                
                prevMonth = n;
                prevDay = m - 1;
            }
            return $"Предыдущая дата : {prevDay}.{prevMonth}";
        }
    }
}
