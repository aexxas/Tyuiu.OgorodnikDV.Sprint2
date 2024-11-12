using Tyuiu.OgorodnikDV.Sprint2.Task2.V18.Lib;

namespace Tyuiu.OgorodnikDV.Sprint2.Task2.V18.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 9, y = 6;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}