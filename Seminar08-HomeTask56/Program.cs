// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");

        }
        System.Console.WriteLine();
    }
}

int[] SumOfLine(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i, j];

        }

    }
    return array;
}

int MinElementIndexOfArray(int[] array)
{
    int minElement = 0;
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (minElement < array[i])
        {
            minElement = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
}
int m = ReadInt("Введите количеcтво строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
int[] array = SumOfLine(matrix);
int minIndexOfMinElementOfArray = MinElementIndexOfArray(array);

Console.WriteLine();
Console.WriteLine(minIndexOfMinElementOfArray+1 + "-номер строки с наименьшей суммой элементов");