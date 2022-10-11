/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                resultMatrix[i,j] += matrix1[i, n] * matrix2[n, j];
            }
        }
    }
    return resultMatrix;
}

int rowsCount1 = GetCountFromUser("Введите количество строк в первой матрице");
int columnsCount1rowsCount2 = GetCountFromUser("Введите количество столбцов в первой матрице и количество строк во второй матрице");
int columnsCount2 = GetCountFromUser("Введите количество столбцов во второй матрице");
int minValue = GetNumberFromUser("Введите минимальное значение генерируемых матриц");
int maxValue = GetNumberFromUser("Введите максимальное значение генерируемых матриц");
int[,] matrix1 = InitRandomMatrix(rowsCount1, columnsCount1rowsCount2, minValue, maxValue);
int[,] matrix2 = InitRandomMatrix(columnsCount1rowsCount2, columnsCount2, minValue, maxValue);
/*int[,] matrix1 = {
    {2, 4},
    {3, 2}
};
int[,] matrix2 = {
    {3, 4},
    {3, 3}
};*/
PrintInConsoleWithColor("Сгенерированная матрица 1:", ConsoleColor.Green);
Console.WriteLine();
PrintMatrix(matrix1);
PrintInConsoleWithColor("Сгенерированная матрица 2:", ConsoleColor.Green);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
PrintInConsoleWithColor("Результат произведения этих двух матриц:", ConsoleColor.Green);
Console.WriteLine();
PrintMatrix(resultMatrix);