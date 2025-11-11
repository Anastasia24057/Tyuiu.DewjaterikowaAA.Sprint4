// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint4.Task2.V25.Lib;
Random rnd = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Подсчитать произведение чётных элементов массива                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] numsArray = new int[11];


for (int i = 0; i < 11; i++)
{
    numsArray[i] = rnd.Next(3, 9);
}
Console.WriteLine("Массив");
for (int i = 0; i < 11;i++)
{
    Console.WriteLine(numsArray[i] + "\t");
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Произведение чётных элементов массива = " + ds.Calculate(numsArray));
Console.ReadKey();