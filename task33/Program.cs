/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
        PrintInConsoleWithColor($"{j}\t", ConsoleColor.Red);
    }
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        PrintInConsoleWithColor($"{i} \t", ConsoleColor.Red);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] InitRandomMatrix(int height, int width, int minRandomValue, int maxRandomValue)
{
    int[,] matrix = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            matrix[i, j] = new Random().Next(minRandomValue, maxRandomValue + 1);
        }
    }
    return matrix;
}

void TurnMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                (matrix[j, i], matrix[i, j]) = (matrix[i, j], matrix[j, i]);
            }
        }
    }
    else
    {
        PrintInConsoleWithColor("Невозможно перевернуть матрицу", ConsoleColor.Red);
        Console.WriteLine();
    }
}

int[,] GetTurnMatrix(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[j, i] = matrix[i, j];
        }
    }
    return result;
}

int[,] matrix = InitRandomMatrix(4, 4, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(GetTurnMatrix(matrix));
Console.WriteLine();
TurnMatrix(matrix);
PrintMatrix(matrix);