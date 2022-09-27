/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

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
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается целое число. {userInformation}: ", ConsoleColor.DarkYellow);
    }
    return result;
}

int GetSumOfDigits(int number)
{
    int result = 0;
    number = Math.Abs(number);
    while (number != 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int number = GetNumberFromUser("Введите число");
Console.WriteLine($"{number} -> {GetSumOfDigits(number)}");