// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string prompt)
{
Console.WriteLine(prompt);
return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int num)
{
if (num == 0) return;

Console.Write(num+" ");
WriteNumbers(num-1);
}


WriteNumbers(ReadInt("Введите число: "));
