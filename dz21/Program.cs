/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation}: ");
    while (!int.TryParse(Console.ReadLine(), out result) || result < 10000 || result > 99999)
    {
        Console.Write($"Ошибка ввода! Ожидается целое пятизначное число. {userInformation}: ");
    }
    return result;
}

bool isPalindrome(int number)
{
    // return number/1000 == number%10 * 10 + number%100 / 10; // частный случай
    int numberTemp = number;
    int numberInvers = 0;
    while (numberTemp != 0)
    {
        numberInvers = numberInvers * 10 + numberTemp % 10;
        numberTemp /= 10;
    }
    return number == numberInvers;
}

int userNumber = getNumberFromUser("Введите число");
string answer = isPalindrome(userNumber) ? "да" : "нет";
Console.WriteLine($"{userNumber} -> {answer}");