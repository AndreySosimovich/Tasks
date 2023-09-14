// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Ошибка вввода! ");
    return;
}

Console.Write($"M = {numberM}; N = {numberN} -> ");

if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}

int SumNaturalDigit(int numM, int numN)
{
    if (numM == numN) return 0;
    else
    {
        numM++;
        return numM + SumNaturalDigit(numM, numN);
    }
}
Console.Write(SumNaturalDigit(numberM - 1, numberN));

 