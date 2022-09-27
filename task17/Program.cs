/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

byte[] InitBoolArray(int count)
{
    byte[] result = new byte[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = (byte)new Random().Next(0, 2);
    }
    return result;
}

void PrintArray(byte[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i == 0 ? "" : ", ");
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

PrintArray(InitBoolArray(8));
