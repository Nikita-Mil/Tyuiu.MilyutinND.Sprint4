using Tyuiu.MilyutinND.Sprint4.Task7.V10.Lib;

namespace Tyuiu.MilyutinND.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 3;
            int colums = 4;
            int[,] mrtx = new int[rows, colums];
            string str = "695847142536";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, colums, str);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}