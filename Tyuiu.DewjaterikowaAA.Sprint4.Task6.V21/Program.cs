// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint4.Task6.V21.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (статистический ввод)                           *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных [Facebook, Twitter, Instagram, Snapchat,    *");
Console.WriteLine("* LinkedIn, Pinterest, Reddit], используя класс Array                     *");
Console.WriteLine("* подсчитайте количество элементов, длина которых меньше 8.               *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

var net = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < net.Length; i++)
{
    Console.WriteLine(net[i]);
}

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("Kоличество элементов, длина которых меньше 8 = " + ds.Calculate(net));
Console.ReadKey();