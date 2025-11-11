using Tyuiu.DewjaterikowaAA.Sprint4.Task2.V25.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint4.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 8, 6, 3, 2, 7 };
            int wait = 384;
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}
