using Tyuiu.KarnaukhovDA.Sprint2.Task4.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                             *");
        Console.WriteLine("* Тема: Тернарный оператор                                                                              *");
        Console.WriteLine("* Задание #4                                                                                            *");
        Console.WriteLine("* Вариант #11                                                                                           *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу которая вычисляет требуемое значение с использованием тернарного оператора         *");
        Console.WriteLine("* где пользователь вводит значение переменных x,y с клавиатуры                                          *");
        Console.WriteLine("*                                                                                                       *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("Введите значение X :");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y :");
        double y = Convert.ToDouble(Console.ReadLine());

        double res = ds.Calculate(x, y);

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("Значение функции =" + res);

        Console.ReadKey();
    }
}