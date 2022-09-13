//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
double [,] array = new double[rows,cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i,j] = Math.Round(new Random().Next(-11,11)*
                                new Random().NextDouble(),2);//NextDouble() дает случайное вещественное число. 

        Console.Write($" {array[i,j]}");
    }
    Console.WriteLine();
}

*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[rows,cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i,j]  = new Random().Next(-11,11);

        Console.Write($" {array[i,j]}");
    }
    Console.WriteLine();
}
Console.Write("Введите номер строки элемента:");
int numberrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int numbercols = Convert.ToInt32(Console.ReadLine());

if (numberrows<=rows && numbercols<=cols)
{
    Console.WriteLine ($"Элемент массива:{array[numberrows-1,numbercols-1]}");   
}
else
{
    Console.WriteLine("Элемент не существует");
}

*/


//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

/*

double[,] CreateRandom2dArray(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void  Create2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void Show2dArray(double[,] array)
{
    double s;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        s = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            s = s + array[i, j];
        }
        s = s / array.GetLength(0);
        Console.Write($" {s} ");
    }
}
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = CreateRandom2dArray(rows, cols, 0, 9);
Create2dArray(array);
Console.WriteLine();
Show2dArray(array);

*/

