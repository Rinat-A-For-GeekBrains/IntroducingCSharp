// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите  трехзначное число");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 99 && N < 1000)
{
    int DeleteRightNumber = N / 10;
    int MiddleN = DeleteRightNumber % 10;

System.Console.Write("Вторая цифра числа "+MiddleN);
}