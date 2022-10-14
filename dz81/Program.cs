/* Все задачи решаются через Рекурсию

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int GetSumNaturalNumbers(int firstNumber, int lastNumber)
{
    if (lastNumber == firstNumber) {
        return lastNumber;
    }
    return lastNumber + GetSumNaturalNumbers(firstNumber, lastNumber - 1);
}

int firstNumber = GetNumberFromUser("Введите число M");
int lastNumber = GetNumberFromUser("Введите число N");
if (lastNumber < firstNumber) (lastNumber, firstNumber) = (firstNumber, lastNumber);
int sum = GetSumNaturalNumbers(firstNumber, lastNumber);
Console.WriteLine($"M = {firstNumber}; N = {lastNumber} -> {sum}");