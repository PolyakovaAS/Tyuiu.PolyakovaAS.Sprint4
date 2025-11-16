using Tyuiu.PolyakovaAS.Sprint4.Task1.V1.Lib;
namespace Tyuiu.PolyakovaAS.Sprint4.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };
            int res = ds.Calculate(array);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}
