using Microsoft.VisualStudio.TestPlatform.TestHost;
using Tyuiu.MilyutinND.Sprint4.Task0.V7.Lib;

namespace Tyuiu.MilyutinND.Sprint4.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalt()
        {
            
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.GetMultOddArrEl(array);
            int wait = 178605;
            Assert.AreEqual(wait, res);

        }
    }
}