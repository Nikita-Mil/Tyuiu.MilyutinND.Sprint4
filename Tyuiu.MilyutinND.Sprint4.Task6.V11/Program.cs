using Tyuiu.MilyutinND.Sprint4.Task6.V11.Lib;

Console.Title = "Спринт #4 | Выполнил: Милютин Н. Д. | СМАРТб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Класс Array                                                       *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Милютин Никита Дмитриевич | СМАРТб-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив  данных [\"Кошка\", \"Собака\", \"Слон\", \"Жираф\"*");
Console.WriteLine("* , \"Бегемот\", \"Игуана\", \"Ягуар\"]\r\n//используя класс Array        *");
Console.WriteLine("* подсчитайте количество элементов, длина которых равна 5.                *");

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

var animal = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < animal.Length - 1; i++)
{
    Console.WriteLine(animal[i]);
}

Console.WriteLine("****************************************************************************");
Console.WriteLine("*РЕЗУЛЬТАТ:                                                                *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Количество элементов длинна которых = 5: ");

int nums = ds.Calculate(animal);

Console.WriteLine(nums);
Console.ReadKey();