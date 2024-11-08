using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MilyutinND.Sprint4.Task4.V16.Lib
{
    public class DataService : ISprint4Task4V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        matrix[i, j] = 1;
                }
            }
            return matrix;
        }
    }
}
//Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с клавиатуры 
//    в диапазоне от 3 до 7. Заменить четные элементы массива на 1.

 

//6, 5, 6, 7, 3,

//5, 4, 6, 7, 3,

//5, 5, 5, 6, 5,

//6, 5, 4, 4, 3,

//4, 5, 4, 5, 5,
