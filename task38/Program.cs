/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
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
    while (!int.TryParse(Console.ReadLine(), out result) || result < 0)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается натуральное число. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int SumDigitsOfNumber(int number)
{
    int digit = number % 10;
    if (digit == 0) return 0;
    return digit + SumDigitsOfNumber(number / 10);
}

int number = GetNumberFromUser("Введите число");
int sumDigits = SumDigitsOfNumber(number);
Console.WriteLine($"{number} -> {sumDigits}");