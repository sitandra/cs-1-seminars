/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
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

ulong Power(int number, int degree)
{
    if (degree == 1) return (ulong)number;
    return (ulong)number * Power(number, degree - 1);
}

int number = GetNumberFromUser("Введите число A");
int degree = GetNumberFromUser("Введите степень B");
ulong result = Power(number, degree);
Console.WriteLine($"A = {number}; B = {degree} -> {result}");