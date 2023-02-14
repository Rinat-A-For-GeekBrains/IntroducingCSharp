// See https://aka.ms/new-console-template for more information
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
while (N > 999)
{
    N = N / 10;
}


int ThirdNumber = N % 10;

// System.Console.WriteLine($"Третья цифра ", + ThirdNumber);
System.Console.WriteLine(ThirdNumber);