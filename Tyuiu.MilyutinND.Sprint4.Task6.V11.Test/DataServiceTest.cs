using Tyuiu.MilyutinND.Sprint4.Task6.V11.Lib;

namespace Tyuiu.MilyutinND.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var animal = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            int res = ds.Calculate(animal);
            int waik = 3;
            Assert.AreEqual(waik, res);
        }
    }
}