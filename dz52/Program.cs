/* Задача (сложная не на оценку)*
Напишите программу, котрая находит подмножество данного множества чисел такое, что сумма его элементов равна заданному числу */

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

void PrintArray(int[] array, bool newLine = true)
{
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    if (newLine) Console.WriteLine("]");
    else Console.Write("]");
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

void AddSubsetsSkeletonLayer(List<int>[] subsets, int numbersLength, int leftBorder, int rightBorder)
{ // Добавляем слой подмножеств
    int newLeftBorder = rightBorder;
    int index = rightBorder;
    for (int i = leftBorder; i < rightBorder; i++)
    {
        int start = subsets[i][^1] + 1;
        for (int j = start; j < numbersLength; j++)
        {
            subsets[index] = new(subsets[i]) { j };
            index++;
        }
    }
    if (subsets[index - 1].Count != numbersLength)
    {
        AddSubsetsSkeletonLayer(subsets, numbersLength, newLeftBorder, index);
    }
}

List<int>[] GetSubsetsSkeleton(int[] numbers)
{
    List<int>[] subsets = new List<int>[(int)Math.Pow(2, numbers.Length) - 1]; // Пустое множество нас не интересует, поэтому -1
    for (int i = 0; i < numbers.Length; i++)
    {
        subsets[i] = new List<int>() { i };
    }
    if (numbers.Length > 1)
    {
        AddSubsetsSkeletonLayer(subsets, numbers.Length, 0, numbers.Length);
    }
    return subsets;
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

List<List<int>> GetSubsetsBySum(int[] numbers, int sum)
{
    List<List<int>> setsBySum = new();
    List<int>[] subsets = GetSubsetsSkeleton(numbers);
    foreach (List<int> subset in subsets)
    {
        if (GetNumbersSumByIndexes(numbers, subset) == sum)
        {
            setsBySum.Add(GetSubsetByIndexes(numbers, subset));
        }
    }
    return setsBySum;
}

int[] set = InitRandomNumbersSet(50, -100, 100);
//var sortedset = set.OrderBy(n=>n).ToArray();
PrintArray(set);
int sum = GetNumberFromUser("Введите число");
SortSet(set);
PrintArray(set);
List<List<int>> subsets = GetSubsetsBySum(set, sum);
if (subsets.Count > 0)
{
    PrintInConsoleWithColor($"Следующие множества дают сумму {sum}:", ConsoleColor.DarkMagenta);
    Console.WriteLine();
    PrintSubsets(subsets);
}
else
{
    PrintInConsoleWithColor($"В этом множестве нет подмножеств, сумма элементов которых равна {sum}!", ConsoleColor.DarkRed);
}

//List<List<int>> result = new List<List<int>>();

