using Tyuiu.MilyutinND.Sprint4.Task7.V10.Lib;
//Добавление к решению итоговых проектов по спринту
Console.Title = "Спринт #4 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"695847142536\". Преобразуйте ее в   *");
Console.WriteLine("* матрицу 3 на 4 и\r\nподсчитайте сумму нечетных чисел.                   *");

DataService ds = new DataService();

int rows = 3;
int colums = 4;
int[,] mrtx = new int[rows, colums];

string str = "695847142536";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int index = 0;

Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.Write($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("****************************************************************************");
Console.WriteLine("*РЕЗУЛЬТАТ:                                                                *");
Console.WriteLine("****************************************************************************");

int res = ds.Calculate(rows, colums, str);

Console.WriteLine("Сумма нечетных чисел = " +  res);
Console.ReadKey();