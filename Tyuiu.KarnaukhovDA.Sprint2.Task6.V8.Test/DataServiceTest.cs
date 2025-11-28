using Tyuiu.KarnaukhovDA.Sprint2.Task6.V8.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint2.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Предыдущая дата : 14.5", ds.FindDateOfPreviousDay(15, 5));

            Assert.AreEqual("Предыдущая дата : 28.2", ds.FindDateOfPreviousDay(1, 3));

            Assert.AreEqual("Предыдущая дата : 30.4", ds.FindDateOfPreviousDay(1, 5));

            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfPreviousDay(1, 1));
        }
    }
}
