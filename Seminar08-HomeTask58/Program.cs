// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write(matrix[i, j] + "\t");

        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++){
                matrix[i, j] = matrix[i, j] + (matrix1[i, k] * matrix2[k, j]);
            }
        }
    }
    return matrix;

}

bool MatrixMultiplicateValidate(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(0) == matrix2.GetLength(1) && matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        System.Console.WriteLine("Умножение возможно");
        return true;
    }
    else
    {
        System.Console.WriteLine("Умножение невозможно");
        return false;
    }

}

int m = ReadInt("Введите количеcтво строк первой матрицы: ");
int n = ReadInt("Введите количество столбцов первой матрицы: ");
int[,] matrix1 = CreateMatrix(m, n);

PrintMatrix(matrix1);

int c = ReadInt("Введите количеcтво строк второй матрицы: ");
int r = ReadInt("Введите количество столбцов второй матрицы: ");
int[,] matrix2 = CreateMatrix(c, r);

PrintMatrix(matrix2);

if (MatrixMultiplicateValidate(matrix1, matrix2))
{
int[,] matrix = MatrixMultiplication(matrix1, matrix2);
Console.WriteLine();
PrintMatrix(matrix);
}

