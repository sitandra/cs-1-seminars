/* Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника */

using System.Globalization;

void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

int GetCountFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число больше 0. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

/*ulong Factorial(int number)
{
    ulong factorial = 1;
    for (int i = 2; i <= number; i++){
        factorial *= (ulong)i;
    }
    return factorial;
}
ulong GetBinomialCoefficient(int n, int m)
{
    ulong value = Factorial(n) / (Factorial(m) * Factorial(n - m));
    return value;
}*/

ulong GetBinomialCoefficient(int n, int m)
{
    if (m == 0)
    {
        return 0;
    }
    if (m > n - m)
    {
        m = n - m;
    }
    ulong result = 1;
    for (ulong i = 1; i <= (ulong)m; ++i)
    {
        result *= (ulong)n - (ulong)m + i;
        result /= i;
    }
    return result;
}

void PrintPascalTriangle(int rowCount)
{
    int symbolsCountInRow = (rowCount * 2) - 1;
    int numberCount = 1;
    ulong maxValue = GetBinomialCoefficient(rowCount - 1, rowCount / 2);
    int spacerCount = maxValue.ToString(CultureInfo.InvariantCulture).Length;
    for (int row = 0; row < rowCount; row++)
    {
        int emptySymbolsCount = (symbolsCountInRow - ((numberCount * 2) - 1)) / 2;
        for (int i = 0; i < emptySymbolsCount; i++)
        {
            Console.Write($"{"".PadLeft(spacerCount)}");
        }
        for (int num = 0; num < numberCount; num++)
        {
            ulong value = GetBinomialCoefficient(row, num);
            Console.Write($"{value.ToString(CultureInfo.InvariantCulture).PadLeft(spacerCount)}{"".PadLeft(spacerCount)}");
        }
        Console.WriteLine();
        numberCount++;
    }
}

int rowCount = GetCountFromUser("Введите количество строк треугольника Паскаля");
PrintPascalTriangle(rowCount);