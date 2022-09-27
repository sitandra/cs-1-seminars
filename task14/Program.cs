/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

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
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается целое число больше нуля. {userInformation}: ", ConsoleColor.DarkYellow);
    }
    return result;
}

int GetSumOfRange(int startNumber, int endNumber)
{
    int result = Math.Min(startNumber, endNumber);
    int max = Math.Max(startNumber, endNumber);
    for (int i = result + 1; i <= max; i++)
    {
        result += i;
    }
    return result;
}

int number = GetNumberFromUser("Введите число A");
Console.WriteLine($"{number} -> {GetSumOfRange(1, number)}");