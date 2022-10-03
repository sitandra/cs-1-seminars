/* Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */
double[] copyArray(double[] array)
{
    double[] arr = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
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

double[] array = { 2, 4, 8.3, 10 };
double[] arrayCopy = copyArray(array);

PrintArray(array);
PrintArray(arrayCopy);