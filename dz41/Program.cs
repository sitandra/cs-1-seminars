/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

int[] InitRandomArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
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

int GetSumOfNumbersInOddPositions(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i++)
    {
        if (i % 2 != 0) sum += numbers[i];
    }
    return sum;
}

int[] numbers = InitRandomArray(4, -100, 100);
PrintArray(numbers, false);
Console.WriteLine($" -> {GetSumOfNumbersInOddPositions(numbers)}");