/* Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
 */

/*void PrintInConsoleWithColor(string message, ConsoleColor color)
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

List<int> GetUniqueValuesInMatrix(int[,] matrix)
{
    List<int> uniqueValues = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (!uniqueValues.Contains(matrix[i, j])) uniqueValues.Add(matrix[i, j]);
        }
    }
    return uniqueValues;
}

int[,] GetInformationAboutCountUniqueValuesInMatrix(int[,] matrix)
{
    List<int> uniqueValues = GetUniqueValuesInMatrix(matrix);
    int[,] result = new int[2, uniqueValues.Count()];
    for (int idx = 0; idx < result.GetLength(1); idx++)
    {
        result[0, idx] = uniqueValues[idx];
        result[1, idx] = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == uniqueValues[idx]) result[1, idx]++;
            }
        }
    }
    return result;
}

int[,] matrix = InitRandomMatrix(4, 3, -9, 9);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(GetInformationAboutCountUniqueValuesInMatrix(matrix));*/

int[,] generateArray(int height, int width, int deviation)
{
    int[,] generatedArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return generatedArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void showArray(int[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] dictNum(int[,] inputArray, int size)
{
    int[] result = new int[size * 2 + 1];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            result[inputArray[i,j] + size]++; 
        }
    }
    return result;
}

void printDictNum(int[] dictNum)
{
    int size = (dictNum.Length - 1) / 2;
    for (int i = 0; i < dictNum.Length; i++)
    {
        if (dictNum[i] != 0)
        {
            Console.WriteLine($"Элемент {i - size} встречается {dictNum[i]} раз");
        }
    }
}

int size = 10;
int[,] generatedArray = generateArray(5, 5, size);
showArray(generatedArray);

int[] dictNumber = dictNum(generatedArray, size);
printDictNum(dictNumber);