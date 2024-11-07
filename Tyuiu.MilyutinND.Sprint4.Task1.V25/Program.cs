﻿using Tyuiu.MilyutinND.Sprint4.Task1.V25.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (Ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 7 подсчитать сумму четных   *");
Console.WriteLine("* элементов массива. С клавиатуры:6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2*");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] array = { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };


Console.WriteLine("Массив = { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 }");

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Произведение нечетных элементов массива = " + ds.Calculate(array));

Console.ReadKey();