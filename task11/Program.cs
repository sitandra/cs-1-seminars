//  Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
int getQuarterNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation}: ");
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1 || result > 4)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число от 1 до 4. {userInformation}: ");
    }
    return result;
}
string getCoordinateRangeFromQuarter(int quarterNumber)
{
    string result;
    switch(quarterNumber)
    {
        case 1:
            result = "x > 0, y > 0";
            break;
        case 2:
            result = "x > 0, y < 0";
            break;
        case 3:
            result = "x < 0, y < 0";
            break;
        case 4:
            result = "x < 0, y > 0";
            break;
        default:
            result = "Ошибка, такой четверти не существует";
            break;
    }
    return result;
}

int userQuarterNumber = getQuarterNumberFromUser("Введите число от 1 до 4");
Console.WriteLine(getCoordinateRangeFromQuarter(userQuarterNumber));
