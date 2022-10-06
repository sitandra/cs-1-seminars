/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void PrintArray(double[] array)
{
    Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"; {array[i]}");
    }
    Console.WriteLine(".");
}

double[] GetAveragesInColumnMatrix(int[,] matrix)
{
    double[] averageValues = new double[matrix.GetLength(1)];
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        int sum = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            sum += matrix[row, col];
        }
        averageValues[col] = Math.Round((double)sum / (double)matrix.GetLength(0), 1);
    }
    return averageValues;
}

int[,] matrix = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
PrintMatrix(matrix);
double[] averageValues = GetAveragesInColumnMatrix(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(averageValues);