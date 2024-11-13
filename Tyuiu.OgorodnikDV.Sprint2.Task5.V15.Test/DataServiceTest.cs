using Tyuiu.OgorodnikDV.Sprint2.Task5.V15.Lib;

namespace Tyuiu.OgorodnikDV.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            string res = ds.FindDayName(7);
            Assert.AreEqual("Воскресенье", res);
        }
    }
}