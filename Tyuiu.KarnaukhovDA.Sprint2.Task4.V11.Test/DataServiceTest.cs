using Tyuiu.KarnaukhovDA.Sprint2.Task4.V11.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint2.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 9.486;
            Assert.AreEqual(wait, res);
        }
        [TestMethod] 
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = -121;
            double res = ds.Calculate(x, y);
            double wait = -121;
            Assert.AreEqual(wait, res);
        }
    }
}
