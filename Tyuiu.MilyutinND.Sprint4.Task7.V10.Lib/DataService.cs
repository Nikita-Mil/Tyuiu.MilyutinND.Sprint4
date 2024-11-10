using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MilyutinND.Sprint4.Task7.V10.Lib
{
    public class DataService : ISprint4Task7V10
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mrtx = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mrtx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int count = 0;
            for (int i = 0;i< n; i++)
            {
                for (int j = 0; j< m;j++)
                {
                    if (mrtx[i,j] % 2 != 0)
                    {
                        count = count + mrtx[i,j];
                    }
                }
            }
            return count;
        } 
    }
}
//Дана строка из одноразрядных цифр "695847142536". Преобразуйте ее в матрицу 3 на 4 и
//подсчитайте сумму нечетных чисел.