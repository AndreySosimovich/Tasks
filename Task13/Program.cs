﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("В введеном числе нет третьей цифры");
    return;
}
int thirdDigit = ThirdDigit(number);
Console.WriteLine($"Третья цифра числа - {thirdDigit}");
int ThirdDigit(int num)
{
    while (num > 999) num = num / 10;
    int x = num % 10;
    return x;
}

 




