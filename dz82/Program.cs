/* Все задачи решаются через Рекурсию

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

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
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается неотрицательное целое число. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int GetAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return GetAkkerman(m - 1, 1);
    }
    return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}

int firstNumber = GetNumberFromUser("Введите число m");
int lastNumber = GetNumberFromUser("Введите число n");
int result = GetAkkerman(firstNumber, lastNumber);
Console.WriteLine($"m = {firstNumber}; n = {lastNumber} -> A(m, n) = {result}");