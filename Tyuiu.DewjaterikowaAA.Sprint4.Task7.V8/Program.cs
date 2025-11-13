// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint4.Task7.V8.Lib;
int n = 3;
int m = 4;
int[,] mtrx = new int[n, m];
string value = "264795863157";

DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (статистический ввод)                           *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр '264795863157'.Преобразуйте ее в      *");
Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int index = 0;
Console.WriteLine("\nМассив:");
for (int i = 0; i < n; i++)
{
    for (int j =0; j<m; j++)
    {
        Console.Write($"{value[index]} \t");
        index++;
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("Сумма нечётных элементов массива =  " + ds.Calculate(n,m,value));
Console.ReadKey();