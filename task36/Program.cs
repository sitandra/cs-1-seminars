/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

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
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается натуральное число больше 1. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

void PrintNaturalNumbers(int number)
{
    if (number == 1) {
        return;
    }
    PrintNaturalNumbers(number - 1);
    Console.Write($", {number}");
}

int number = GetNumberFromUser("Введите число N");
Console.Write($"N = {number} -> 1");
PrintNaturalNumbers(number);
Console.WriteLine();