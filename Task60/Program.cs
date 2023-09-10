// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int[,,] CreateArray3dRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] array = new int[rows, columns, depth];
    Random rnd = new Random();
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] += count;
                count += 1;
            }
        }
    }
    return array;
}

void PrintArray3dIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],5}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] array3d = CreateArray3dRndInt(2, 2, 2, 10, 99);
Console.WriteLine();
if (array3d.Length > 99)
{
    Console.WriteLine("С введенными значениями заполнение массива только двухзначными числами невозможно ");
    return;
}
Console.WriteLine();
PrintArray3dIndex(array3d);



