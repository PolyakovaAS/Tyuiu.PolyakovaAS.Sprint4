using Tyuiu.PolyakovaAS.Sprint4.Task0.V9.Lib;
namespace Tyuiu.PolyakovaAS.Sprint4.Task0.V9.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int result = ds.GetSumEvenArrEl(array);

            int expected = 4 + 6 + 2 + 8 + 4 + 6 + 8; 

            Assert.AreEqual(expected, result);
        }
    }
}
