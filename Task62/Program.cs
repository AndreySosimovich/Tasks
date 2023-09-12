// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Введите количество элементов в строке");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов в cтолбце");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] SpinMatrix(int rows, int collumns)
{
    int[,] matrix = new int[collumns, rows];
    int count = 1;
    int temp = 0;
    int i, j = 0;
    int rows1 = rows;
    int collumns1 = collumns;

    while (count <= rows1 * collumns1)
    {
        for (i = temp; i < rows; i++)
            matrix[j, i] = count++;
        j = rows - 1;
        for (i = temp + 1; i < collumns; i++)
            matrix[i, j] = count++;
        j = collumns - 1;
        for (i = rows - 2; i >= temp; i--)
            matrix[j, i] = count++;
        j = temp;
        for (i = collumns - 2; i > temp; i--)
            matrix[i, j] = count++;
        rows--;
        collumns--;
        temp++;
        j = temp;
    }
    return matrix;
}

void PrintSpiralMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0,2} ", matrix[i, j]);
        Console.WriteLine();
    }
}

int[,] array2d = SpinMatrix(row, columns);
PrintSpiralMatrix(array2d);
Console.WriteLine();
 