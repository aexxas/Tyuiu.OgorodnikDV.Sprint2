using Tyuiu.OgorodnikDV.Sprint2.Task1.V16.Lib;

namespace Tyuiu.OgorodnikDV.Sprint2.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Огородник Д. В. | ИСПб-24-1";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #2                                                           *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                    *");
            Console.WriteLine("* Задание #1                                                          *");
            Console.WriteLine("* Вариант #16                                                         *");
            Console.WriteLine("* Выполнила: Огородник Дарья Вячеславовна |  ИСПб-24-1                *");
            int a = 145;
            int b = 716;
            int c = 144;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
