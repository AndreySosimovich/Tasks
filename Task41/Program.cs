// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвертое число:");
int number4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятое число:");
int number5 = Convert.ToInt32(Console.ReadLine());

int[] array = new int[]{number1, number2, number3, number4, number5};

int PositiveNumber(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum ++; 
    }
    return sum;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
PrintArray(array);
int positiveNumber = PositiveNumber(array);
Console.WriteLine($" -> {positiveNumber}");