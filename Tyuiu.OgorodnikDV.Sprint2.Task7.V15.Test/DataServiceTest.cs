using Tyuiu.OgorodnikDV.Sprint2.Task7.V15.Lib;

namespace Tyuiu.OgorodnikDV.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(true, dataService.CheckDotInShadedArea(-1.2, 1.2));
            Assert.AreEqual(false, dataService.CheckDotInShadedArea(0.1, 0.5));
        }
    }
}