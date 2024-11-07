using Tyuiu.MilyutinND.Sprint4.Task2.V6.Lib;
Console.Title = "Спринт #4 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
Console.WriteLine("* зслучайными в диапазоне от 2 до 8 подсчитать произведение нечетных      *");
Console.WriteLine("* элементов массива.                                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
DataService ds =new DataService();
Random rnd = new Random();

Console.WriteLine("Введите колличество элемментов массива: ");

int len = Convert.ToInt32(Console.ReadLine());

int[] numsArry = new int[len];
for (int i = 0; 1 <= len; i++)
{
    numsArry[i] = rnd.Next(2, 8);
}

Console.WriteLine("Массив: ");
for (int i =0; 1 <= len; i++)
{
    Console.WriteLine(numsArry[i] + "\t"); 
}

Console.WriteLine();
Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");

int res = ds.Calculate(numsArry);

Console.WriteLine("Произведение нечетных элементов = " + res);
Console.ReadKey();