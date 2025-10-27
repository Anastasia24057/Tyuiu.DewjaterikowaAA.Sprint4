// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint4.Task0.V18.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статистический ввод)                          *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Подсчитать сумму нечётных элементов массива.                            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
Console.WriteLine("Исходный массив:");
for (int i = 0; i <= numsArray.Length-1;i++)
{
    Console.WriteLine(numsArray[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма нечётных элементов массива = "+ds.GetSumOddArrEl(numsArray));
Console.ReadKey();
