using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MilyutinND.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length/rows; 

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        count = Math.Min(count, array[i, j]);
                    }
                }
            }
            return count;
        }
    }
}
//Дан двумерный целочисленный массив 5 на 5 элементов, заполненный
//статическими значениями в диапазоне от 3 до 8. Найдите минимальный элемент в первом столбце массива.
//8, 7, 7, 8, 5,

//4, 3, 5, 3, 6,

//5, 3, 8, 6, 3,

//6, 3, 8, 5, 4,

//3, 6, 8, 3, 4,