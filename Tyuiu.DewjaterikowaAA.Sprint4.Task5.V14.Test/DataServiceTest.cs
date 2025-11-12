using Tyuiu.DewjaterikowaAA.Sprint4.Task5.V14.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint4.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[3, 3] { { 1, 2, -5 }, { 3, 4, -3 }, { 7, 2, 3 } };
            int res = ds.Calculate(mas2);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }
    }
}
