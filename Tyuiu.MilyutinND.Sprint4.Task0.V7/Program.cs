//using Tyuiu.MilyutinND.Sprint4.Task0.V7.Lib;

//DataService ds= new DataService();

//Console.Title = "Спринт #4 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";

//Console.WriteLine("***************************************************************************");
//Console.WriteLine("* Спринт #4                                                               *");
//Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
//Console.WriteLine("* Задание #0                                                              *");
//Console.WriteLine("* Вариант #7                                                              *");
//Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
//Console.WriteLine("***************************************************************************");
//Console.WriteLine("* УСЛОВИЕ:                                                                *");
//Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
//Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
//Console.WriteLine("* нечетных элементов массива.  {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}             *");
//Console.WriteLine("***************************************************************************");
//Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
//Console.WriteLine("***************************************************************************");

//int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };


//Console.WriteLine("Массив = { 9,8,7,9,5,4,3,2,3,7}");

//Console.WriteLine("********************************************************************************");
//Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
//Console.WriteLine("********************************************************************************");

//Console.WriteLine("Произведение нечетных элементов массива = " + ds.GetMultOddArrEl(array));

//Console.ReadKey();
int[,] array = new int[,] { { 5, -6,3 }, { 8, -9, 7 }, {2, -5, 4 } };
int s = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] % 2 == 0)
        {
            s += array[i, j];
        }
    }
}
Console.WriteLine(s);