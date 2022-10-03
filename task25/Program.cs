/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

int GetNumberFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число больше нуля. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int getLengthBoolArray(int number)
{
    int count = 0;
    while (number != 0)
    {
        number /= 2;
        count++;
    }
    return count;
}

bool[] getBoolArray(int number)
{
    int length = getLengthBoolArray(number);
    bool[] boolArray = new bool[length];
    for (int index = 0; index < length; index++)
    {
        boolArray[length - 1 - index] = number % 2 != 0;
        number /= 2;
    }
    return boolArray;
}

void printBoolArray(bool[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] ? "1" : "0");
    }
    Console.WriteLine();
}

int number = GetNumberFromUser("Введите число");
bool[] boolArray = getBoolArray(number);
printBoolArray(boolArray);