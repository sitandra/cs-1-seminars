/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
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

int[,] InitSpiralMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= Math.Pow(size, 2))
    {
        matrix[i, j] = value;
        if (i <= j + 1 && i + j < size - 1)
        {
            j++;
        }
        else if (i < j && i + j >= size - 1)
        {
            i++;
        }
        else if (i >= j && i + j > size - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
        value++;
    }
    return matrix;
}

int size = GetCountFromUser("Введите ширину и высоту генерируемой матрицы");
int[,] matrix = InitSpiralMatrix(size);
PrintInConsoleWithColor("Сгенерированная матрица:", ConsoleColor.Green);
Console.WriteLine();
PrintMatrix(matrix);