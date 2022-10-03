/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

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
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 1)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число больше 1. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int[] GetFibonacci(int n)
{
    int[] fibonacci = new int[n];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for(int i = 2; i < n; i++)
    {
        fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
    }
    return fibonacci;
}

void PrintArray(int[] array, bool newLine = true)
{
    Console.Write($"[{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    if(newLine) Console.WriteLine("]");
    else Console.Write("]");
}

int number = GetNumberFromUser("Введите N");
int[] result = GetFibonacci(number);
PrintArray(result);