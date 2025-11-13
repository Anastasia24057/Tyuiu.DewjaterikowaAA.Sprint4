using Tyuiu.DewjaterikowaAA.Sprint4.Task7.V8.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint4.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string value = "264795863157";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 37;
            Assert.AreEqual(wait, res);

        }
    }
}
