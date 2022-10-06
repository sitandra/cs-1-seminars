/* Задача 51: Задайте двумерный массив. Найдите Сумма элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

int[] GetDiagonal(int[,] matrix)
{
    int bound = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
    int[] diagonal = new int[bound];
    for (int i = 0; i < bound; i++)
    {
        diagonal[i] = matrix[i, i];
    }
    return diagonal;
}

void PrintSumOfDiagonal(int[] diagonal)
{
    Console.Write(diagonal[0]);
    for (int i = 1; i < diagonal.Length; i++)
    {
        Console.Write($" + {diagonal[i]}");
    }
    Console.Write($" = {diagonal.Sum()}");
}

int[,] matrix = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

PrintMatrix(matrix);
Console.WriteLine();
PrintSumOfDiagonal(GetDiagonal(matrix));