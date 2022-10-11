/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void PrintList(List<int> list)
{

    Console.Write($"{list[0]}");
    for (int i = 1; i < list.Count; i++)
    {
        Console.Write($", {list[i]}");
    }
    Console.WriteLine();
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

List<int> GetRowsIndexesWithMinSum(int[,] matrix)
{
    List<int> rowsIndexex = new();
    int? minSum = null;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        if (minSum == rowSum)
        {
            rowsIndexex.Add(i);
        }
        else if (minSum == null)
        {
            minSum = rowSum;
            rowsIndexex.Add(i);
        }
        else if (minSum > rowSum)
        {
            minSum = rowSum;
            rowsIndexex.Clear();
            rowsIndexex.Add(i);
        }
    }
    return rowsIndexex;
}

int rowsCount = GetCountFromUser("Введите количество строк в матрице");
int columnsCount = GetCountFromUser("Введите количество столбцов в матрице");
int minValue = GetNumberFromUser("Введите минимальное значение генерируемой матрицы");
int maxValue = GetNumberFromUser("Введите максимальное значение генерируемой матрицы");
int[,] matrix = InitRandomMatrix(rowsCount, columnsCount, minValue, maxValue);
PrintInConsoleWithColor("Сгенерированная матрица:", ConsoleColor.Green);
Console.WriteLine();
PrintMatrix(matrix);
List<int> rowNumberWithMinSum = GetRowsIndexesWithMinSum(matrix);
if (rowNumberWithMinSum.Count > 1)
{
    PrintInConsoleWithColor("Номера строк с наименьшей суммой значений: ", ConsoleColor.Green);
}
else
{
    PrintInConsoleWithColor("Номер строки с наименьшей суммой значений: ", ConsoleColor.Green);
}
PrintList(rowNumberWithMinSum);