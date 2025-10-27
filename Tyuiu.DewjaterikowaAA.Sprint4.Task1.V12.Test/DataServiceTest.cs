using Tyuiu.DewjaterikowaAA.Sprint4.Task1.V12.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint4.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8 };
            int wait = 2205;
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}
