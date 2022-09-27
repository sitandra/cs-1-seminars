/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

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

int GetPow(int number, int degree)
{
    return (int)Math.Pow((int)number, (int)degree);
}

int number = GetNumberFromUser("Введите число A");
int degree = GetNaturalNumberFromUser("Введите натуральную степень B");
Console.WriteLine($"{number},{degree} -> {GetPow(number, degree)}");