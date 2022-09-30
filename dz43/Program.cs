/* Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

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

int[] GetMagic(int[] numbers)
{
    int[] result = new int[numbers.Length % 2 == 0 ? numbers.Length / 2 : numbers.Length / 2 + 1];
    int lastElement = numbers.Length - 1;
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        result[i] = numbers[i] * numbers[lastElement - i];
    }
    if (numbers.Length % 2 != 0) result[result.Length - 1] = numbers[numbers.Length / 2];
    return result;
}

void PrintResult(int[] numbers)
{
    int[] newNumbers = GetMagic(numbers);
    PrintArray(numbers, false);
    Console.Write($" -> ");
    PrintArray(newNumbers);
}

PrintResult(InitRandomArray(5, 0, 10));
PrintResult(InitRandomArray(4, 0, 10));