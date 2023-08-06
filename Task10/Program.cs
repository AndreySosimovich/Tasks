// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999) 
{
    Console.WriteLine("Введено некорректное число");
    return;
}    
int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа  {secondDigit}");
int SecondDigit(int num) 
{
    while (num > 100) num /= 10;
    int x = num % 10;
    return x;
}


     