// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

int ReturnValue(int[,] matrix, int m, int n)
{
    if ((m < matrix.GetLength(0)) && (n < matrix.GetLength(1)))
    {
        return matrix[m-1, n-1];
    }
    else
    {
        Console.WriteLine("Такой позиции в массиве нет");
        return -1;
    }
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
int m = ReadInt("Введите количеcтво строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine("Введите искомую позицию элемента матрицы: ");

int p = ReadInt("");
int r = ReadInt("");

Console.WriteLine($"Элемент со строкой {p} и столбцом {r} равен {ReturnValue(matrix,p,r)}");


