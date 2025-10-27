using Tyuiu.DewjaterikowaAA.Sprint4.Task0.V18.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint4.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int wait = 41;
            int res = ds.GetSumOddArrEl(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}
