// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 78 -> 8 12-> 2 85 -> 8
int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    return new Random().Next(minBorder, maxBorder + 1);
}
int getMaxDigitFromNumber(int number)
{
    int maxDigit = 0;
    while (number > 0)
    {
        int currentDigit = number % 10;
        if (maxDigit < currentDigit)
        {
            maxDigit = currentDigit;
        }
        number = number / 10;
    }
    return maxDigit;
}
for (int i = 0; i < 10; i++)
{
    int number = getRandomNumberFromRange(10, 99);
    int maxDigit = getMaxDigitFromNumber(number);
    Console.WriteLine($"{number} -> {maxDigit}");
}