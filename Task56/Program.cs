// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SummRow(int[,] matrix, int i)
{
    int sumRow = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumRow = sumRow + matrix[i, j];
    }
    return sumRow;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
 
int minsummRow = 0;
int summRow = SummRow(array2d, 0);

for (int i = 1; i < array2d.GetLength(0); i++)
{
  int temp = SummRow(array2d, i);
  if (summRow > temp)
  {
    summRow = temp;
    minsummRow = i;
  }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов  - {minsummRow + 1}. (Сумма элементов: {summRow})");
 