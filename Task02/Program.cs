// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int numder1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numder2 = Convert.ToInt32(Console.ReadLine());
if (numder1 > numder2)
{
    Console.WriteLine($"Большее число {numder1}");
}
else Console.WriteLine($"Большее число {numder2}");
if (numder1 == numder2) Console.WriteLine("Вы ввели одинаковые числа");
