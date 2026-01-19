using Tyuiu.KarnaukhovDA.Sprint2.Task7.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                             *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                               *");
        Console.WriteLine("* Задание #7                                                                                            *");
        Console.WriteLine("* Вариант #8                                                                                            *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и вычисляет,    *");
        Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.                                       *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        Console.Write("Введите значение переменной X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение переменной Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

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
            Console.WriteLine("Точка находиться не в заштрихованной области");
        }

        Console.ReadKey();
    }
}