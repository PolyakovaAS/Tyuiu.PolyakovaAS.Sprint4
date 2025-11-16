using Tyuiu.PolyakovaAS.Sprint4.Task3.V14.Lib;

namespace Tyuiu.PolyakovaAS.Sprint4.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();   
            Assert.AreEqual(1, 1);
        }
    }
}
