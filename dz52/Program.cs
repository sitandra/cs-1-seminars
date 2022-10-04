/* Задача (сложная не на оценку)*
Напишите программу, которая находит подмножество данного множества чисел такое, что сумма его элементов равна заданному числу */

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

int[] InitRandomNumbersSet(int setLength, int minNumber, int maxNumber)
{
    int[] result = new int[setLength];
    for (int i = 0; i < setLength; i++)
    {
        int temp = new Random().Next(minNumber, maxNumber + 1);
        while (result.Contains(temp))
        {
            temp = new Random().Next(minNumber, maxNumber + 1);
        }
        result[i] = temp;
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write($"{{{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.WriteLine("}");
}

void PrintSubsets(List<List<int>> subsets)
{
    foreach (List<int> subset in subsets)
    {
        Console.Write($"{{{subset[0]}");
        for (int i = 1; i < subset.Count; i++)
        {
            Console.Write($", {subset[i]}");
        }
        Console.WriteLine("}");
    }
}

int GetNumbersSumByIndexes(int[] numbers, List<int> indexes)
{
    int result = 0;
    foreach (int index in indexes)
    {
        result += numbers[index];
    }
    return result;
}

void SortSet(int[] numbers)
{
    int left = 0;
    int right = numbers.Length - 1;

    while (left < right)
    {
        for (int i = left; i < right; i++)
        {
            if (numbers[i] > numbers[i + 1]) (numbers[i], numbers[i + 1]) = (numbers[i + 1], numbers[i]);
        }
        right--;

        for (int i = right; i > left; i--)
        {
            if (numbers[i - 1] > numbers[i]) (numbers[i - 1], numbers[i]) = (numbers[i], numbers[i - 1]);
        }
        left++;
    }
}

void FindSubsetsBySumInLayer(List<int> subset, int[] numbers, List<List<int>> foundSubsets, int sum)
{
    if (GetNumbersSumByIndexes(numbers, subset) == sum)
    {
        foundSubsets.Add(GetSubsetByIndexes(numbers, subset));
    }
    int start = subset[^1] + 1;
    for (int j = start; j < numbers.Length; j++)
    {
        FindSubsetsBySumInLayer(new(subset) { j }, numbers, foundSubsets, sum);
    }
}

List<List<int>> FindSubsetsBySum(int[] numbers, int sum)
{
    List<List<int>> foundSubsets = new();
    for (int i = 0; i < numbers.Length; i++)
    {
        FindSubsetsBySumInLayer(new List<int>() { i }, numbers, foundSubsets, sum);
    }
    return foundSubsets;
}

List<int> GetSubsetByIndexes(int[] numbersSet, List<int> indexes)
{
    List<int> result = new();
    foreach (int index in indexes)
    {
        result.Add(numbersSet[index]);
    }
    return result;
}

// Осторожно! Проверок будет 2^|N|, где N – мощность множества. На больших множествах программа будет долго висеть.
// Внимание! InitRandomNumbersSet() уйдет в себя, если не сможет сгенерировать N уникальных элементов, поэтому диапазон должен быть указан достаточный
int[] set = InitRandomNumbersSet(10, -10, 10);

PrintInConsoleWithColor($"Дано множество: ", ConsoleColor.DarkBlue);
PrintArray(set);
int sum = GetNumberFromUser("Введите число");
SortSet(set); // Чтобы подмножества выводились симпатично
List<List<int>> subsets = FindSubsetsBySum(set, sum);
if (subsets.Count > 0)
{
    PrintInConsoleWithColor($"Найдены подмножества, сумма элементов которых равна {sum} ({subsets.Count} шт.):", ConsoleColor.DarkMagenta);
    Console.WriteLine();
    PrintSubsets(subsets);
}
else
{
    PrintInConsoleWithColor($"В этом множестве нет подмножеств, сумма элементов которых равна {sum}", ConsoleColor.DarkRed);
}

