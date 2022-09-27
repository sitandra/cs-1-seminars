/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */
int GetNumberFromUser(string userInformation)
{
    int result;
    Console.Write($"{userInformation}: ");
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число больше нуля. {userInformation}: ");
    }
    return result;
}

int GetMultiplicationOfRange(int startNumber, int endNumber)
{
    int result = Math.Min(startNumber, endNumber);
    int max = Math.Max(startNumber, endNumber);
    for (int i = result + 1; i <= max; i++)
    {
        result *= i;
    }
    return result;
}

int number = GetNumberFromUser("Введите число N");
Console.WriteLine($"{number} -> {GetMultiplicationOfRange(number,1)}");