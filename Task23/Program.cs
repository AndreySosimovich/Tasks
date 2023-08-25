// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void TableCube(int num)
{
    for (int i = 1; i <= num; i++)
    Console.WriteLine($"{i, 3} | {i*i*i, 5}");
}

Console.WriteLine("Введите любое натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

TableCube(number);