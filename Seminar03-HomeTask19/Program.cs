﻿// //Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5- значное число");
string number = Console.ReadLine();
int charQ = number.Length;
if (charQ == 5)
{
    if (number[0] == number[4] &&  number[1] == number[3])
    {
       Console.WriteLine("Число является палиндромом");
     }
    
    else
    {
        Console.WriteLine("Число не палиндром"); 
    }
   
}
else
{
Console.WriteLine("Число не 5-значное");

}