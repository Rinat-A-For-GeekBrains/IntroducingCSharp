// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string inputFromLine = Console.ReadLine();
    int result = Convert.ToInt32(inputFromLine);
    return result;
}

int SumAllDigit (int number)
{
    int result = 0;
    while (number > 0)
    {
    
     result = result + number % 10;
    number = number / 10;
    }
    return result;
 
}
int number = Prompt("Введите число:");
Console.WriteLine($"Сумма цифр числа {number} = {SumAllDigit(number)}");        