/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

int GetNumberFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int GetCountFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число больше 0. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
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

int[,] InitRandomMatrix(int rowsCount, int columnsCount, int minValue, int maxValue)
{
    if (maxValue < minValue) (minValue, maxValue) = (maxValue, minValue);
    int[,] matrix = new int[rowsCount, columnsCount];
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnsCount; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void SortMatrixRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int left = 0;
        int right = matrix.GetLength(1) - 1;

        while (left < right)
        {
            for (int j = left; j < right; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1]) (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
            }
            right--;

            for (int j = right; j > left; j--)
            {
                if (matrix[i, j - 1] < matrix[i, j]) (matrix[i, j - 1], matrix[i, j]) = (matrix[i, j], matrix[i, j - 1]);
            }
            left++;
        }
    }
}

int rowsCount = GetCountFromUser("Введите количество строк в матрице");
int columnsCount = GetCountFromUser("Введите количество столбцов в матрице");
int minValue = GetNumberFromUser("Введите минимальное значение генерируемой матрицы");
int maxValue = GetNumberFromUser("Введите максимальное значение генерируемой матрицы");
int[,] matrix = InitRandomMatrix(rowsCount, columnsCount, minValue, maxValue);
PrintInConsoleWithColor("Сгенерированная матрица:", ConsoleColor.Green);
Console.WriteLine();
PrintMatrix(matrix);
PrintInConsoleWithColor("Матрица после сортировки строк по убыванию:", ConsoleColor.Green);
Console.WriteLine();
SortMatrixRows(matrix);
PrintMatrix(matrix);