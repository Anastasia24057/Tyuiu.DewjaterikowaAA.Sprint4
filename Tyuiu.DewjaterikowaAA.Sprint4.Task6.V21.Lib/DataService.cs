using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DewjaterikowaAA.Sprint4.Task6.V21.Lib
{
    public class DataService : ISprint4Task6V21
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, net => net.Length < 8);
            return mas.Length;
        }
    }
}
