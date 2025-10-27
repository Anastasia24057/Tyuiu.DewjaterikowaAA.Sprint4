// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint4.Task1.V12.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Подсчитать произведение нечётных элементов массива, запрашивая с        *");
Console.WriteLine("* клавиатуры данные.                                                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] numsArray = new int[13];

Console.WriteLine("Введите 13 элементов массива (числа в диапазоне от 4 до 9)");
for (int i = 0; i < 13;)
{
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
    if (numsArray[i] >= 4 && numsArray[i] <= 9)
    { i++; }
    else
    { Console.WriteLine("Значение не входит в промежуток от 4 до 9, введите еще раз"); }
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Произведение нечётных элементов массива = " + ds.Calculate(numsArray));
Console.ReadKey();








