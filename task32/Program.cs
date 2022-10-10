/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

void PrintMatrix(int[,] matrix)
{
    Console.Write(" \t");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        PrintInConsoleWithColor($"{j}\t", ConsoleColor.Green);
    }
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        PrintInConsoleWithColor($"{i} \t", ConsoleColor.Green);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] InitRandomMatrix(int height, int width, int leftRangeValue, int rightRangeValue)
{
    int[,] matrix = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            matrix[i, j] = new Random().Next(leftRangeValue, rightRangeValue + 1);
        }
    }
    return matrix;
}

void SwapMatrixRows(int[,] matrix, int firstRow, int secondRow)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[firstRow, i];
        matrix[firstRow, i] = matrix[secondRow, i];
        matrix[secondRow, i] = temp;
    }
}

int n = 5;
int m = 4;

int[,] matrix = InitRandomMatrix(m, n, -100, 100);
PrintMatrix(matrix);
Console.WriteLine();
SwapMatrixRows(matrix, 0, matrix.GetLength(0) - 1);
PrintMatrix(matrix);