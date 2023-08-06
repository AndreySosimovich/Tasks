// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, которая соответствует дню недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
   Console.WriteLine("Цифра не соответствует дню недели");
   return;
}

bool result = WeekDigit(number, 6, 7);
Console.WriteLine(result? "Да, этот день выходной": "Нет, это не выходной день");

bool WeekDigit(int num, int num1, int num2)
{
   return (num == num1 || num == num2);
}