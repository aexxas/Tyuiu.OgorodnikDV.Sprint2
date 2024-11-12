using Tyuiu.OgorodnikDV.Sprint2.Task3.V30.Lib;

namespace Tyuiu.OgorodnikDV.Sprint2.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            var res = ds.Calculate(x);
            var wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}