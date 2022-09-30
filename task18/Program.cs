/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
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

void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.WriteLine("]");
}

void InitSum(int[] numbers, out int negativeNumbersSum, out int positiveNumbersSum)
{
    negativeNumbersSum = 0;
    positiveNumbersSum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) negativeNumbersSum += numbers[i];
        else positiveNumbersSum += numbers[i];
    }
}

int[] numbers = InitRandomArray(12, -9, 9);
int negativeNumbersSum;
int positiveNumbersSum;
InitSum(numbers, out negativeNumbersSum, out positiveNumbersSum);
PrintArray(numbers);
Console.WriteLine($"Сумма положительных чисел = {positiveNumbersSum}");
Console.WriteLine($"Сумма отрицательных чисел = {negativeNumbersSum}");