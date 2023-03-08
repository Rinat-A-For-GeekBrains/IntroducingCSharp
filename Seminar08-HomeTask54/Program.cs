// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void OrderMatrix(int[,] matrix)
{
    for (
    int i = 0; i < matrix.GetLength(0); i++
    )
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
        
                for (int l = j + 1; l < matrix.GetLength(1); l++)

                    if (matrix[i,j] < matrix[i,l])
                    {
                        int tempvar = matrix[i,j];
                        matrix[i,j] = matrix[i,l];
                        matrix[i,l] = tempvar;
                    }

            
        }
}
int m = ReadInt("Введите количеcтво строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
OrderMatrix(matrix);
PrintMatrix(matrix);

