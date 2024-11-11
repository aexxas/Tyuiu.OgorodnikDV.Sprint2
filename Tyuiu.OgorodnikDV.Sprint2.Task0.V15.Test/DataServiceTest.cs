using Tyuiu.OgorodnikDV.Sprint2.Task0.V15.Lib;

namespace Tyuiu.OgorodnikDV.Sprint2.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3105, y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, true, true, false, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}