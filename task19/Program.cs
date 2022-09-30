/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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
    if(newLine) Console.WriteLine("]");
    else Console.Write("]");
}

void InvertNumbersInArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }
}

int[] numbers = InitRandomArray(4, -9, 9);
PrintArray(numbers, false);
InvertNumbersInArray(numbers);
Console.Write(" -> ");
PrintArray(numbers);