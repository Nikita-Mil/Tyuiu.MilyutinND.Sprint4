using Tyuiu.MilyutinND.Sprint4.Task5.V13.Lib;

Console.Title = "Спринт #4 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от -2 до 5. Заменить отрицательные    *");
Console.WriteLine("* элементы на 0.                                                          *");

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Random rnd = new Random();

Console.WriteLine("Введите количество столбцов: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] x = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        x[i, j] = rnd.Next(-2, 5);
    }
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{x[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("******************************************************************************");
Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("******************************************************************************");

int[,] res = ds.Calculate(x);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{res[i, j]}\t");
    }
}
Console.WriteLine();