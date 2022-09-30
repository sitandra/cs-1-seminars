/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

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
    if(newLine) Console.WriteLine("]");
    else Console.Write("]");
}

int CountOfNumbersFromRange(int[] numbers, int minRange, int maxRange)
{
    if (maxRange < minRange) {
        int temp = maxRange;
        maxRange = minRange;
        minRange = temp;
    }
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= minRange && numbers[i] <= maxRange) count++;
    }
    return count;
}

int[] numbers = InitRandomArray(123, 0, 255);
PrintArray(numbers, false);
Console.WriteLine($" -> {CountOfNumbersFromRange(numbers, 10, 99)}");