using Tyuiu.KarnaukhovDA.Sprint2.Task5.V12.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay1()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 03;
            int n = 15;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = ("14.03.2024");
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidFindDateOfPreviousDay2()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 01;
            int n = 01;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = ("31.12.2023");
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidFindDateOfPreviousDay3()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 03;
            int n = 01;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = ("29.02.2024");
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidFindDateOfPreviousDay4()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 05;
            int n = 01;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = ("30.04.2024");
            Assert.AreEqual(wait, res);
        }
        
 
    }
}
