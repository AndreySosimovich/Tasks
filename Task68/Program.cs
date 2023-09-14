// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Задайте первое неотрицательное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе неотрицательное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Ошибка вввода! ");
    return;
}

Console.Write($"m = {numberM}; n = {numberN} -> A (m,n) = ");
Console.WriteLine(FunctionAkkerman(numberM, numberN));

int FunctionAkkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0)
    {
        return FunctionAkkerman(numM - 1, 1);
    }
    else
    {
        return (FunctionAkkerman(numM - 1, FunctionAkkerman(numM, numN - 1)));
    }
}
