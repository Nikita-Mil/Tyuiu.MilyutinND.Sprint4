using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MilyutinND.Sprint4.Task2.V6.Lib
{
    public class DataService : ISprint4Task2V6
    {
        public int Calculate(int[] array)
        {
            int sumArray = 1;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumArray = sumArray * array[i];
                }
            }
            return sumArray;
        }
    }
}
//Дан одномерный целочисленный массив на 15 элементов заполненный
//случайными в диапазоне от 2 до 8 подсчитать произведение нечетных элементов массива.