// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);

if (remainder == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно {remainder}");

int Remainder(int num1, int num2)
{
    return num1 % num2;
}
