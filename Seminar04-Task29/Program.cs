// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string inputFromLine = Console.ReadLine();
    int result = int.Parse(inputFromLine);
    return result;
}

int[] GenerateArray(int Length)
{
int[] array = new int[Length];
Random rnd = new Random();
for (int i=0; i < Length; i++)
    {
    array[i] = rnd.Next(65535);
    }
return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++) 
    {
    Console.Write($"{array[i]}, ");
    }
Console.Write($"{array[array.Length-1]}");
Console.WriteLine("]");
}

int length = Prompt("Введите длину массива: ");
int[] array = GenerateArray(length);
PrintArray(array);