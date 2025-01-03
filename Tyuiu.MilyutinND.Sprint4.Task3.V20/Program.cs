﻿using Tyuiu.MilyutinND.Sprint4.Task3.V20.Lib;

DataService ds = new DataService();
int[,] array = new int[5, 5] { { 8, 7, 7, 8, 5 },
                                           { 4, 3, 5, 3, 6 },
                                           { 5, 3, 8, 6, 3 },
                                           { 6, 3, 8, 5, 4 },
                                           { 3, 6, 8, 3, 4 } };
int rows = array.GetUpperBound(0) + 1;
int columns = array.Length / rows;

Console.Title = "Спринт #4 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите минимальный      *");
Console.WriteLine("* элемент в первом столбце массива.                                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Исходный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine(array[i, j]);
    }
}


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"Минимальный элемент в первом столбце массива: {ds.Calculate(array)}");
Console.ReadKey();