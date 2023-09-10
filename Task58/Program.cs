// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplicationResult(int[,] matrix, int[,] matrix2)
{
    int[,] matrixRes = new int[matrix.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrixRes[i, j] = 0;

            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrixRes[i, j] += matrix[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixRes;
}

int[,] array1d = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(array1d);
Console.WriteLine();

int[,] array2d = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

if (array1d.GetLength(1) != array2d.GetLength(0))
{
    Console.WriteLine("Нарушено условие умножения матриц! ");
    return;
}

int[,] arrayRes = new int[0, 0];
arrayRes = MatrixMultiplicationResult(array1d, array2d);
Console.WriteLine("Результирующая матрица: ");
PrintMatrix(arrayRes);
