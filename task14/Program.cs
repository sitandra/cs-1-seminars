/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

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

int Sum(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result += i;
    }
    return result;
}

int number = GetNumberFromUser("Введите число A");
Console.WriteLine($"{number} -> {Sum(number)}");