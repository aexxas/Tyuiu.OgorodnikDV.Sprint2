using Tyuiu.OgorodnikDV.Sprint2.Task6.V3.Lib;

namespace Tyuiu.OgorodnikDV.Sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidDayNum()
        {
            DataService ds = new DataService();

            Console.Title = "������ #2 | ��������: ��������� �. �. | �����-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ������ #2                                                               *");
            Console.WriteLine("* ����: ��������� ���������� �� switch                                    *");
            Console.WriteLine("* ������� #6                                                              *");
            Console.WriteLine("* ������� #3                                                              *");
            Console.WriteLine("* ��������: ��������� ������ �������� | �����-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* �������:                                                                *");
            Console.WriteLine("* ��������� ���������, ������� � ����������� �� ����������� ������ ���    *");
            Console.WriteLine("* ������ (1, 2, �, 7) ������� �� ����� ��� ��������                       *");
            Console.WriteLine("* (�����������, �������, �, �����������)                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* �������� ������:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("������� ���������� ����� ��� ������:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ���������:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.FindDayName(value);
            Console.WriteLine(res);

            Console.ReadLine();

        }
    }
}