using Tyuiu.KarnaukhovDA.Sprint2.Task5.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                             *");
        Console.WriteLine("* Тема: Оператор switch                                                                                 *");
        Console.WriteLine("* Задание #5                                                                                            *");
        Console.WriteLine("* Вариант #12                                                                                           *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу, которая использует оператор switch                                                *");
        Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                                                  *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:                                       *");
        Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m определить дату предыдущего дня*");
        Console.WriteLine("* Заданный год является високосным.                                                                     *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("Введите год:");
        int g = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите месяц:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

        string res = ds.FindDateOfPreviousDay(g,  m, n);

        Console.WriteLine(res);

        Console.ReadLine();

    }
}