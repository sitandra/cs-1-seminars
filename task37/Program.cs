/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
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

void PrintNaturalNumbers(int firstNumber, int lastNumber)
{
    if (lastNumber <= firstNumber) {
        return;
    }
    PrintNaturalNumbers(firstNumber, lastNumber - 1);
    Console.Write($", {lastNumber}");
}

int firstNumber = GetNumberFromUser("Введите число M");
int lastNumber = GetNumberFromUser("Введите число N");
if (lastNumber < firstNumber) (lastNumber, firstNumber) = (firstNumber, lastNumber);
Console.Write($"M = {firstNumber}; N = {lastNumber} -> {firstNumber}");
PrintNaturalNumbers(firstNumber + 1, lastNumber);
Console.WriteLine();