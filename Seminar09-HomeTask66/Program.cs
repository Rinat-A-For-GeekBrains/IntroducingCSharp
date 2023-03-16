// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string prompt){
Console.WriteLine(prompt);
return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
if (n == m-1) return 0;
return n + SumNumbers(m, n-1) ;
}

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
if (m < n){
System.Console.WriteLine(SumNumbers(m, n));
} else {
System.Console.WriteLine(SumNumbers(n, m));
}
