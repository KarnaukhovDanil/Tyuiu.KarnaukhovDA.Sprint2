using Tyuiu.KarnaukhovDA.Sprint2.Task7.V8.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint2.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 3.5;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = 0.5;

           
            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;

           
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea3()
        {
            DataService ds = new DataService();

            double x = 2.0;
            double y = 4.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea4()
        {
            DataService ds = new DataService();

            double x = -1.0;
            double y = 4.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea5()
        {
            DataService ds = new DataService();

            double x = -2.0;
            double y = 2.5;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea6()
        {
            DataService ds = new DataService();

            double x = 3.0;
            double y = 4.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea7()
        {
            DataService ds = new DataService();

            double x = 0.0;
            double y = 5.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea8()
        {
            DataService ds = new DataService();

            double x = -2.5;
            double y = 3.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea9()
        {
            DataService ds = new DataService();

            double x = 3.5;
            double y = 3.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea10()
        {
            DataService ds = new DataService();

            double x = -2.0;
            double y = 4.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea11()
        {
            DataService ds = new DataService();

            double x = 3.0;
            double y = 4.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea12()
        {
            DataService ds = new DataService();

            double x = 0.0;
            double y = 0.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;


            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea13()
        {
            DataService ds = new DataService();

            double x = -1.5;
            double y = 3.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;


            Assert.AreEqual(res, wait);
        }
        public void ValidCheckDotInShadedArea14()
        {
            DataService ds = new DataService();

            double x = 3.0;
            double y = 1.0;


            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;


            Assert.AreEqual(res, wait);
        }
    }
}
