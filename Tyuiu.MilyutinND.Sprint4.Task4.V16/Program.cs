using Tyuiu.MilyutinND.Sprint4.Task4.V16.Lib;

Console.Title = "Спринт #4 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7. Заменить четные элементы *");
Console.WriteLine("*  массива на 1.                                                          *");

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] gg = new int[5, 5];
for (int i = 0; i < gg.GetLength(0); i++)
{
    for (int j = 0; j < gg.GetLength(1); j++)
    {
        Console.Write($"Введите {i},{j} элемент массива: ");
        gg[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine();

Console.WriteLine("Массив:");
for (int i = 0; i < gg.GetLength(0); i++)
{
    for (int j = 0; j < gg.GetLength(1); j++)
    {
        Console.Write(gg[i, j] + "\t");
    }
    Console.WriteLine();
}

int[,] res = ds.Calculate(gg);
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < res.GetLength(0); i++)
{
    for (int j = 0; j < res.GetLength(1); j++)
    {
        Console.Write(res[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.ReadLine();