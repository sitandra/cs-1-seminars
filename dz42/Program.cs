/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] InitRandomArray(int length, double start, double end)
{
    double[] result = new double[length];
    start *= 100;
    end *= 100;
    for (int i = 0; i < length; i++)
    {
        result[i] = (double)(new Random().Next((int)start, (int)end + 1)) / 100;
    }
    return result;
}

void PrintArray(double[] array, bool newLine = true)
{
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    if (newLine) Console.WriteLine("]");
    else Console.Write("]");
}

double GetDifferentBetweenMinAndMax(double[] numbers)
{
    double min = numbers[0];
    double max = numbers[0];
    foreach(var value in numbers)
    {
        if (value < min) min = value;
        if (value > max) max = value;
    } 
    return max - min;
}

double[] numbers = InitRandomArray(5, -5, 5);
PrintArray(numbers, false);
Console.WriteLine($" -> {Math.Round(GetDifferentBetweenMinAndMax(numbers),2)}");