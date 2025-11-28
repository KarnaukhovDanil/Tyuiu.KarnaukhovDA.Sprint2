using Tyuiu.KarnaukhovDA.Sprint2.Task6.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                             *");
        Console.WriteLine("* Тема: Оператор switch                                                                                 *");
        Console.WriteLine("* Задание #6                                                                                            *");
        Console.WriteLine("* Вариант #8                                                                                            *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу, которая использует оператор switch                                                *");
        Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                                                  *");
        Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: n (порядковый номер месяца)           *");
        Console.WriteLine("* и m (число). По заданным n и m определить дату предыдущего дня                                        *");
        Console.WriteLine("* (принять, что n и m не характеризуют 1 января)                                                        *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("Введите месяц:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

       
            string res = ds.FindDateOfPreviousDay(n, m);

        Console.WriteLine(res);

        Console.ReadKey();


    }
}