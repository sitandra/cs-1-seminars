/* Все задачи решаются через Рекурсию

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
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
    if (number == 1)
    {
        Console.Write($"{number}");
    } else {
        Console.Write($"{number}, ");
        PrintNaturalNumbers(number - 1);
    }
}

int number = GetNumberFromUser("Введите число N");
Console.Write($"N = {number} -> ");
PrintNaturalNumbers(number);
Console.WriteLine();