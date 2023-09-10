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
int[,] matrix = new int[columns, row];
int count = 1;
int temp = 0;
int i, j = 0;
int row1 = row;
int columns1 = columns;

void PrintSpiralMatrix(int[,] matrix)
{
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0,2} ", matrix[i, j]);
        Console.WriteLine();
    }
}

while (count <= row1 * columns1)
{
    for (i = temp; i < row; i++)
        matrix[j, i] = count++;
    j = row - 1;
    for (i = temp + 1; i < columns; i++)
        matrix[i, j] = count++;
    j = columns - 1;
    for (i = row - 2; i >= temp; i--)
        matrix[j, i] = count++;
    j = temp;
    for (i = columns - 2; i > temp; i--)
        matrix[i, j] = count++;
    row--;
    columns--;
    temp++;
    j = temp;
}
PrintSpiralMatrix(matrix);
Console.WriteLine();