/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/

void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

int GetNumbersCountFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число больше 0. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int GetNumberFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается целое число. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int GetCountOfPositiveNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count++;
    }
    return count;
}

int numbersCount = GetNumbersCountFromUser("Введите количество чисел");
int[] numbers = new int[numbersCount];
for (int i = 0; i < numbersCount; i++)
{
    numbers[i] = GetNumberFromUser($"Введите число №{i + 1}");
}
int positiveNumbersCount = GetCountOfPositiveNumbers(numbers);
PrintInConsoleWithColor($"Положительных чисел {positiveNumbersCount} шт.", ConsoleColor.Green);