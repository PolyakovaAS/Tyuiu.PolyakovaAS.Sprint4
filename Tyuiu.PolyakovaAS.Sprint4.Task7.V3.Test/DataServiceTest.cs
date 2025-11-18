using Tyuiu.PolyakovaAS.Sprint4.Task7.V3.Lib;

namespace Tyuiu.PolyakovaAS.Sprint4.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string value = "27182818";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
