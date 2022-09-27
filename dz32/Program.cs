/* Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33] */

void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

int GetNaturalNumberFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается натуральное число. {userInformation}: ", ConsoleColor.DarkYellow);
    }
    return result;
}

byte[] InitArray99(int length)
{
    byte[] result = new byte[length];
    for (int i = 0; i< length; i++)
    {
        result[i] = (byte)new Random().Next(1,100);
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

PrintArray(InitArray99(GetNaturalNumberFromUser("Введите размер массива")));