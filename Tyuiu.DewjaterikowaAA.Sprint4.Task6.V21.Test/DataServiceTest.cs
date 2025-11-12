using Tyuiu.DewjaterikowaAA.Sprint4.Task6.V21.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint4.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            var net = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
            int res = ds.Calculate(net);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
