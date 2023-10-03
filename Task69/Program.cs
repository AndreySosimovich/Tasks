// Задача 69: Напишите программу, которая на вход принимает два числа А и В, и
//возводит число А в степень числа В.

Console.WriteLine("Введите первое число ");
int digitA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int digitB = Convert.ToInt32(Console.ReadLine());

int PowDigit(int digA, int digB)
{
    if (digB == 0) return 1;
    return digA * PowDigit(digA, digB - 1);
}
Console.WriteLine(PowDigit(digitA, digitB));
