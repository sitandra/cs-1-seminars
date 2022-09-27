/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int GetNumberFromUser(string userInformation)
{
    int result;
    Console.Write($"{userInformation}: ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается целое число. {userInformation}: ");
    }
    return result;
}

int CountDigits(int number)
{
    int count = 0;
    number = Math.Abs(number);
    while (number != 0)
    {
        count ++;
        number /= 10;
    }
    return count;
}

int number = GetNumberFromUser("Введите число");
Console.WriteLine($"{number} -> {CountDigits(number)}");
