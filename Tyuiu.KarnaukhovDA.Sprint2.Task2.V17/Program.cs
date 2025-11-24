using Tyuiu.KarnaukhovDA.Sprint2.Task2.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                             *");
        Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                                                    *");
        Console.WriteLine("* Задание #2                                                                                            *");
        Console.WriteLine("* Вариант #17                                                                                           *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и                              *");
        Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области.                             *");
        Console.WriteLine("*                                                                                                       *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("Введите значение переменной Х :");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y :");
        int y = Convert.ToInt32(Console.ReadLine());

        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

        if(res)
        {
            Console.WriteLine("Точка находиться в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка находиться в не заштрихованной области");
        }

        Console.ReadKey();

    }
}