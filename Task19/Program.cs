// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int num)
{
    if (num < 10000 || num > 99999)
    {
        Console.WriteLine("Вас же просили ввести ПЯТИЗНАЧНОЕ число!!!");
    }
    else if (num/10000 == num%10 && (num/1000)%10 == (num%100)/10)
    Console.WriteLine($"{num} -> Да");
    else Console.WriteLine($"{num} -> Нет");
}

Console.WriteLine("Введите натуральное пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

Palindrom(number);


