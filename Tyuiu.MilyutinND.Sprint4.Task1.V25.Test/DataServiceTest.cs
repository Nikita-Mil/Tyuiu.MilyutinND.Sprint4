using Tyuiu.MilyutinND.Sprint4.Task1.V25.Lib;

namespace Tyuiu.MilyutinND.Sprint4.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };

            int res = ds.Calculate(numsArray);

            int wait = 497664;

            Assert.AreEqual(wait, res);
        }
    }
}