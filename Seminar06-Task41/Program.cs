// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = ReadInt("Введите число");
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountPositve(int[] arr)
{  
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
          count++;      
        }
       
    }
     return count;
}

int M = ReadInt("Введите число М");

int[] MyArr = Array(M);
PrintArray(MyArr);
Console.WriteLine($"Количество положительных чисел {CountPositve(MyArr)}");
