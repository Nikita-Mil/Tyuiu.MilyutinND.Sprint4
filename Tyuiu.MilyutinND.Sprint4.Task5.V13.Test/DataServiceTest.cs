using Tyuiu.MilyutinND.Sprint4.Task5.V13.Lib;

namespace Tyuiu.MilyutinND.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] gg =
            {{1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },};
            int[,] res = ds.Calculate(gg);
            int[,] wait =
            {{1,1,3,1,5 },
                {1,1,3,1,5 },
                {1,1,3,1,5 },
                {1,1,3,1,5 },
                {1,1,3,1,5 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}