using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MilyutinND.Sprint4.Task1.V25.Lib
{
    public class DataService : ISprint4Task1V25
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumArray = sumArray + array[i];
                }
            }
            return sumArray;
        }
    }
}
//Дан одномерный целочисленный массив на 14 элементов заполненный значениями с клавиатуры в диапазоне
//от 1 до 7 подсчитать сумму четных элементов массива. С клавиатуры: 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6,
//int p = 1;

//for (int i = 0; i <= array.Length - 1; i++)
//{
//    if (array[i] % 2 != 0)
//    {
//        p = p * array[i];
//    }
//}
//return p;

//int sumArray = 0;

//for (int i = 0; i <= array.Length - 1; i++)
//{
//    if (array[i] > 10)
//    {
//        sumArray += array[i];
//    }
//}
//return sumArray;