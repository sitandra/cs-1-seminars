/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

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

void InvertArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = temp;
    }
}

int[] numbers = InitRandomArray(5, 0, 9);
PrintArray(numbers, false);
Console.Write(" -> ");
InvertArray(numbers);
PrintArray(numbers);

numbers = InitRandomArray(4, 0, 9);
PrintArray(numbers, false);
Console.Write(" -> ");
InvertArray(numbers);
PrintArray(numbers);