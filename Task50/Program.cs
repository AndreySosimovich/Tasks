﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];  
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("");
    }
}
 
int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine("Введите первое значение позиции элемента массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
if (rows < 0) 
{
    Console.WriteLine("Индекс массива не может иметь отрицательное значение");
    return;
}
Console.WriteLine("Введите второе значение позиции элемента массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (columns < 0) 
{
    Console.WriteLine("Индекс массива не может иметь отрицательное значение"); 
    return;
}
if (rows < array2d.GetLength(0) && columns < array2d.GetLength(1)) 
Console.WriteLine($"На указанной позиции расположен элемент со значением  {array2d[rows, columns]}");
else Console.WriteLine($"{rows}{columns} -> такого числа в массиве нет");

